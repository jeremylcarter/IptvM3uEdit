using IptvM3uEdit.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IptvM3uEdit.WinUI
{
    public partial class Form1 : Form
    {
        private M3uParser _m3uParser;

        public Form1()
        {
            InitializeComponent();

#if DEBUG
            txtFile.Text = @"D:\downloads\tv_channels_scsgkyyd_plus.m3u";
#endif
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFile.Text) && System.IO.File.Exists(txtFile.Text))
            {

                System.IO.StreamReader file = new System.IO.StreamReader(txtFile.Text);
                _m3uParser = new M3uParser(file);
                txtParsedContent.Text = string.Join(Environment.NewLine, _m3uParser.ParsedLines.Select(n => n.ToString()));

                var groups = _m3uParser.ParsedLines.GroupBy(n => n.GroupTitle).Select(grp => grp.First().GroupTitle).OrderBy(n => n).ToList();
                ((ListBox)this.checkedListBoxGroups).DataSource = groups;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxGroups.Items.Count; i++)
            {
                checkedListBoxGroups.SetItemChecked(i, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxGroups.Items.Count; i++)
            {
                checkedListBoxGroups.SetItemChecked(i, false);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (chkOutputSelected.Checked)
            {
                var selectedGroups = checkedListBoxGroups.CheckedItems.Cast<string>().ToList();
                _m3uParser.ParsedLines = _m3uParser.ParsedLines.Where(n => selectedGroups.Contains(n.GroupTitle)).ToList();
            }

            if (chkAdjustUSACA.Checked)
            {
                foreach (var line in _m3uParser.ParsedLines.Where(n => n.GroupTitle.Contains("US/CA")))
                {
                    line.TvgID = line.TvgID.Replace("USA/CA:", "USA#CA:");
                    line.TvgID = line.TvgID.Replace("US/CA:", "USA#CA:");
                }
            }

            if (chkPrefixGroupToName.Checked)
            {
                var prefixes = txtGroupPrefixes.Text.Split(',').ToList();
                var trimedPrefixes = new List<string>();
                foreach (var p in prefixes)
                {
                    trimedPrefixes.Add(p.Trim());
                }

                _m3uParser.PrefixGroupToName(trimedPrefixes);
            }

            _m3uParser.ParsedLines = _m3uParser.ParsedLines.OrderBy(n => n.Name).OrderBy(n => n.GroupTitle).ToList();

            txtExport.Text =
                "#EXTM3U" + Environment.NewLine +
                string.Join(Environment.NewLine, _m3uParser.ParsedLines.Select(n => n.ToString()));

            //reset parsed lines
            System.IO.StreamReader file = new System.IO.StreamReader(txtFile.Text);
            _m3uParser.ParsedLines = _m3uParser.ParseFile(file);
        }
    }
}
