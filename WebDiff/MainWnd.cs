using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using WebDiff.Data;

namespace WebDiff
{
    public partial class MainWnd : Form
    {
        DataSource dataSource = new DataSource();
        public MainWnd()
        {
            InitializeComponent();
            loadSessions();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionFrm sessionFrm = new SessionFrm();
            sessionFrm.Show(this);
        }

        private void refreshSessionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSessions();
        }

        private void loadSessions()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<Session> sessions = dataSource.GetSessions();
            listBox1.Items.AddRange(sessions.ToArray());
            listBox2.Items.AddRange(sessions.ToArray());
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void fetchPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Prompt First...
            CompareResults results = WebDiff.CompareSessions((Session) listBox1.SelectedItem, (Session) listBox2.SelectedItem);
            IMongoClient client = new MongoClient();
            IMongoDatabase database = client.GetDatabase("web-diff");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("compare-results");

            collection.InsertOne(results.ToBsonDocument());
            MessageBox.Show("Saved To Mongo");

        }

        
    }    
}
