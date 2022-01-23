using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Класс формы "About"
    /// </summary>
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Linklabel для перехода на почту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = EmailLinkLabel.Text;
            System.Diagnostics.Process.Start("chrome.exe", url);
        }

        /// <summary>
        /// LinkLabel для перехода на Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutGitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = AboutGitLinkLabel.Text;
            System.Diagnostics.Process.Start("chrome.exe", url);
        }
    }
}
