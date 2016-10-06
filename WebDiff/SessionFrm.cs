using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using OpenQA.Selenium;
using WebDiff.Data;
using WebDiff.Properties;

namespace WebDiff
{
    public partial class SessionFrm : Form
    {
        private WebDiff webDiff;
        public SessionFrm()
        {
            InitializeComponent();
        }

        private void crawlButton_Click(object sender, EventArgs e)
        {
            urlTextBox.Enabled = false;
            button1.Enabled = false;
            String crawlUrl = urlTextBox.Text;
            webDiff = new WebDiff(UrlCleaner.UrlCleaner.GetUri(crawlUrl).Host);
            webDiff.savePicturesToPath = Properties.Settings.Default.DefaultPicturePath + "\\" + DateTime.Now.ToFileTimeUtc() + "\\";
            Directory.CreateDirectory(webDiff.savePicturesToPath);

            webDiff.crawlUrl(crawlUrl);
            button2.Enabled = true;                            
            webDiff.Close();

            foreach (var url in webDiff.DomainUrlsAsUrlObjects)
            {
                listBox1.Items.Add(url);
            }
            button2.PerformClick();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveToMongoButton_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Session session = new Session();
            session.Time = DateTime.Now;
            session.Urls = webDiff.DomainUrlsAsUrlObjects.ToArray();

            IMongoClient client = new MongoClient();
            IMongoDatabase database = client.GetDatabase("web-diff");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("sessions");

            collection.InsertOne(session.ToBsonDocument());
            MessageBox.Show("Saved To Mongo");
        }
    }
}
