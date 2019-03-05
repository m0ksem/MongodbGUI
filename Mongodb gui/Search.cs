using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mongodb_gui
{
    public partial class Search : Form
    {
        IMongoCollection<BsonDocument> collection;
        MainForm parent;

        public Search(IMongoCollection<BsonDocument> collection, MainForm parent)
        {
            this.collection = collection;
            InitializeComponent();
            this.parent = parent;
        }

        private void Search_Load(object sender, EventArgs e)
        {
        }

        public class Searcher
        {
            List<string> groups = new List<string>();
            string originalText;

            public Searcher (string text)
            {
                text = "(" + text + ")";
                originalText = text;
                string group = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        group = "";
                    }
                    if (text[i] == ')')
                    {
                        group += text[i];
                        text = text.Replace(group, "index" + groups.Count);
                        group = group.Replace("(", "");
                        group = group.Replace(")", "");
                        groups.Add(group);
                        group = "";
                        i = 0;
                        continue;
                    }
                    group += text[i];
                }
            }

            public BsonDocument GetFilter ()
            {
                return GetFilter(groups[groups.Count - 1]);
            }
            
            private BsonDocument GetFilter (string group)
            {
                string[] structure = group.Split(' ');
                if (structure.Length == 1)
                {
                    int index = Convert.ToInt32(group.Replace("index", ""));
                    group = groups[index];
                    structure = group.Split(' ');
                }
                switch (structure[1])
                {
                    case "=":
                        structure[1] = "eq";
                        return ComparisonFilter(structure);
                    case "!=":
                        structure[1] = "ne";
                        return ComparisonFilter(structure);
                    case "&&":
                        structure[1] = "and";
                        return LogicalFilter(structure);
                    case "||":
                        structure[1] = "or";
                        return LogicalFilter(structure);
                    case "!":
                        structure[1] = "not";
                        return LogicalFilter(structure);
                    default:
                        return null;
                        break;
                }
            }

            private BsonDocument ComparisonFilter (string[] structure)
            {
                if (!structure[0].StartsWith("index") && !structure[2].StartsWith("index"))
                {
                    if (structure[2].StartsWith("\""))
                    {
                        structure[2] = structure[2].Replace("\"", "");
                        return new BsonDocument(structure[0], new BsonDocument("$" + structure[1], structure[2]));
                    } else {
                        int r = Convert.ToInt32(structure[2]);
                        return new BsonDocument(structure[0], new BsonDocument("$" + structure[1], r));
                    }
                }
                return null;
            }

            private BsonDocument LogicalFilter(string[] structure)
            {
                if (structure[0].StartsWith("index") && structure[2].StartsWith("index"))
                {
                    return new BsonDocument("$" + structure[1], new BsonArray
                            {
                                GetFilter(structure[0]),
                                GetFilter(structure[2])
                            });
                }
                return null;
            }
        }


        private void findButton_Click(object sender, EventArgs e)
        {
            string text = this.findTextBox.Text;
            if (text != null)
            {
                Searcher s = new Searcher(text);
                BsonDocument filter = s.GetFilter();
                var results = this.collection.Find(filter).ToList();
                foreach (var r in results)
                {
                    Console.WriteLine(r);
                }
                ViewCollection mainForm = new ViewCollection(results, collection);
                mainForm.FillCollectionView(results);
                mainForm.Show();
            }
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.parent).RefreshCollectionView();
        }
    }
}