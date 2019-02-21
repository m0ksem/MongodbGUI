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
     public partial class MainForm : Form
    {
        public MMongoDB mongo = null;
        private List<BsonDocument> databases;
        private List<BsonDocument> collections;
        private IMongoDatabase currentDatabase;
        private List<BsonDocument> currentCollectionsItems;
        private IMongoCollection<BsonDocument> currentCollection;
        private TreeNode PanelSelectedElement;
        private TreeNode LastSelectedNode = null;
        private Color LastSelectedColor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm(this);
            Hide();
            connectForm.ShowDialog();
            if (mongo == null)
            {
                Close();
                return;
            }
            Show();
            MongoConnected();
        }

        public void MongoConnected()
        {
            databases = mongo.GetDataBases();

            foreach (BsonDocument item in databases)
            {
                databaseComboBox.Items.Add(item.GetValue("name"));
            }

            databaseComboBox.SelectedIndex = 0;
            currentDatabase = mongo.GetDataBase(databases[0].GetValue("name").ToString());
            collections = mongo.GetCollectionsList(currentDatabase);
        
            collectionsComboBox.Items.Clear();
            foreach (BsonDocument item in collections)
            {
                collectionsComboBox.Items.Add(item.GetValue("name"));
            }

            collectionsComboBox.SelectedIndex = 0;
            currentCollection = currentDatabase.GetCollection<BsonDocument>(collections[0].GetValue("name").ToString());

            var items = mongo.GetItems(currentCollection);
            FillCollectionView(items);
        }

        public void FillCollectionView(List<BsonDocument> items)
        {
            CollectionView.Nodes.Clear();

            foreach (BsonDocument item in items)
            {
                var treeNode = new TreeNode();
                treeNode.Expand();
                treeNode.Text = items.IndexOf(item) + ": Object" ;
                treeNode.BackColor = Color.Honeydew;
                treeNode.Tag = item;

                foreach (BsonElement element in item)
                {               
                    treeNode.Nodes.Add(CreateTreeNode(element));
                }
              
                CollectionView.Nodes.Add(treeNode);
            }
        }

        private TreeNode CreateTreeNode(BsonElement element)
        {
            TreeNode node = new TreeNode();
           
            if (element.Value.BsonType == BsonType.ObjectId)
            {
                node.BackColor = Color.WhiteSmoke;
                node.Text = "ID: " + element.Value + "  - " + element.Value.BsonType;
                node.Tag = element;
            } 
            else if (element.Value.BsonType == BsonType.Array)
            {
                node.Text = element.Name + "  - Array";

                foreach (var children in element.Value.AsBsonArray)
                {
                    if (children.BsonType == BsonType.Document)
                    {
                        TreeNode objectNode = new TreeNode
                        {
                            Text = element.Value.AsBsonArray.IndexOf(children).ToString() + ": Object",
                            BackColor = Color.Honeydew,
                            Tag = children
                        };

                        foreach (var e in children.AsBsonDocument.Elements)
                        {
                            objectNode.Nodes.Add(CreateTreeNode(e));
                        }
                        node.Nodes.Add(objectNode);
                    }
                    else if (children.BsonType == BsonType.String || children.BsonType == BsonType.Int32)
                    {
                        TreeNode stringNode = new TreeNode
                        {
                            Text = element.Value.AsBsonArray.IndexOf(children).ToString() + ": " + children.RawValue.ToString() + "  - " + children.BsonType,
                            Tag = children
                        };

                        node.Nodes.Add(stringNode);
                    }
                    else if (children.BsonType == BsonType.Array)
                    {
                        TreeNode arrayNode = new TreeNode
                        {
                            Text = element.Value.AsBsonArray.IndexOf(children).ToString() + ": Array",
                            Tag = children,
                            BackColor = Color.WhiteSmoke
                        };

                        foreach (BsonValue e in children.AsBsonArray.Values)
                        {
                            arrayNode.Nodes.Add(CreateTreeNode(e));
                        }
                        
                        node.Nodes.Add(arrayNode);
                    }
                }

                node.Tag = element;
                node.BackColor = Color.WhiteSmoke;
            }
            else if (element.Value.BsonType == BsonType.Document)
            {
                node.Text = element.Name + " - Object";

                foreach (BsonElement e in element.Value.AsBsonDocument.Elements)
                {
                    node.Nodes.Add(CreateTreeNode(e));
                }

                node.Tag = element;
                node.BackColor = Color.Honeydew;
            }
            else
            {
                node.Text = element.Name + ": " + element.Value + "  - " + element.Value.BsonType;
                node.Tag = element;
            }
      
            return node;
        }

        private TreeNode CreateTreeNode(BsonValue element)
        {
            TreeNode node = new TreeNode();

            if (element.BsonType == BsonType.Array)
            {
                node.Text = "  - Array";
                foreach (var children in element.AsBsonArray)
                {
                    if (children.BsonType == BsonType.Document)
                    {
                        TreeNode objectNode = new TreeNode
                        {
                            Text = element.AsBsonArray.IndexOf(children).ToString() + ": Object",
                            BackColor = Color.Honeydew,
                            Tag = children
                        };

                        foreach (var e in children.AsBsonDocument.Elements)
                        {
                            objectNode.Nodes.Add(CreateTreeNode(e));
                        }

                        node.Nodes.Add(objectNode);
                    }
                    else if (children.BsonType == BsonType.String || children.BsonType == BsonType.Int32)
                    {
                        TreeNode stringNode = new TreeNode
                        {
                            Text = element.AsBsonArray.IndexOf(children).ToString() + ": " + children.RawValue.ToString() + "  - " + children.BsonType,
                            Tag = children
                        };

                        node.Nodes.Add(stringNode);
                    }
                    else if (children.BsonType == BsonType.Array)
                    {
                        TreeNode arrayNode = new TreeNode
                        {
                            Text = "Array  - []",
                            Tag = children,
                            BackColor = Color.WhiteSmoke
                        };

                        foreach (BsonValue e in children.AsBsonArray.Values)
                        {
                            BsonElement el = new BsonElement(null, e);
                            node.Nodes.Add(CreateTreeNode(el));
                        }
                        
                        node.Nodes.Add(arrayNode);
                    }
                }
                node.Tag = element;
                node.BackColor = Color.WhiteSmoke;
            }
            else if (element.BsonType == BsonType.Document)
            {
                node.Text = " - Object";
                foreach (BsonElement e in element.AsBsonDocument.Elements)
                {
                    node.Nodes.Add(CreateTreeNode(e));
                }
                node.Tag = element;
                node.BackColor = Color.Honeydew;
            }
            else
            {
                node.Text = element + "  - " + element.BsonType;
                node.Tag = element;
            }

            return node;
        }

        private void collectionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = mongo.GetItems(currentDatabase.GetCollection<BsonDocument>(collections[collectionsComboBox.SelectedIndex].GetValue("name").ToString()));
            CollectionView.Nodes.Clear();
            FillCollectionView(items);
        }

        private void databaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDatabase = mongo.GetDataBase(databases[databaseComboBox.SelectedIndex].GetValue("name").ToString());
            collections = mongo.GetCollectionsList(currentDatabase);

            collectionsComboBox.Items.Clear();
            foreach (BsonDocument item in collections)
            {
                collectionsComboBox.Items.Add(item.GetValue("name"));
            }
            collectionsComboBox.SelectedIndex = 0;

            var items = mongo.GetItems(currentDatabase.GetCollection<BsonDocument>(collections[0].GetValue("name").ToString()));
            FillCollectionView(items);
        }

        private void CollectionView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            editPanel.Enabled = true;
            addButton.Enabled = false;

            if (e.Node.Tag is BsonDocument) {
                changeTypeComboBox.Enabled = false;
                NameEditTextBox.Enabled = false;
                ValueEditTextBox.Enabled = false;
                ValueEditTextBox.Text = "";
                NameEditTextBox.Text = "";
                changeTypeComboBox.Text = "";
                addButton.Enabled = true;
            }
            else if (e.Node.Tag is BsonElement)
            {
                BsonElement element = (BsonElement)e.Node.Tag;
                changeTypeComboBox.Enabled = true;
                changeTypeComboBox.Text = element.Value.BsonType.ToString();
                NameEditTextBox.Enabled = true;
                NameEditTextBox.Text = element.Name;

                if (element.Value.BsonType != BsonType.Array && element.Value.BsonType != BsonType.Document)
                {
                    ValueEditTextBox.Enabled = true;
                    ValueEditTextBox.Text = element.Value.ToString();
                }
                else
                {
                    ValueEditTextBox.Enabled = false;
                    ValueEditTextBox.Text = "";
                    addButton.Enabled = true;
                }
                
            } 
            else if (e.Node.Tag is BsonString)
            {
                BsonString element = (BsonString)e.Node.Tag;
                changeTypeComboBox.Enabled = true;
                changeTypeComboBox.Text = element.BsonType.ToString();
                NameEditTextBox.Enabled = false;
                NameEditTextBox.Text = "";
                ValueEditTextBox.Enabled = true;
                ValueEditTextBox.Text = element.Value;
            }

            if (LastSelectedNode != null)
            {
                LastSelectedNode.BackColor = LastSelectedColor;
            }

            PanelSelectedElement = e.Node;
            LastSelectedColor = CollectionView.SelectedNode.BackColor;
            LastSelectedNode = CollectionView.SelectedNode;
            CollectionView.SelectedNode.BackColor = Color.MediumSeaGreen;
        }

        private void NameEditTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private TreeNode FindParentDocument (TreeNode element)
        {
            if (element.Parent == null)
            {
                return (TreeNode) element.Clone();
            }
            return FindParentDocument(element.Parent);
        }

        private TreeNode ReplaceParent(TreeNode element, Object newValues)
        {
            if (element.Parent == null)
            {
                return element;
            }
            if (element.Parent.Tag is BsonElement)
            {
                if (element.Parent.Tag is BsonArray)
                {
                    var array = ((BsonElement)element.Parent.Tag).Value;
                    var arrayContainer = array.AsBsonArray;
                    var bsonElement = (BsonValue)element.Tag;
                    int index = array.AsBsonArray.IndexOf(bsonElement);

                    if (newValues is BsonElement)
                    {
                        array.AsBsonArray[index] = ((BsonElement)newValues).Value;
                    }
                    else
                    {
                        array.AsBsonArray[index] = ((BsonDocument)newValues);
                    }

                    newValues = element.Parent.Tag;
                }
                else if (element.Parent.Tag is BsonDocument)
                {
                    var document = ((BsonElement)element.Parent.Tag).Value.AsBsonDocument;
                    int index = document.IndexOfName(((BsonElement)element.Tag).Name);

                    if (newValues is BsonElement)
                    {
                        document.RemoveElement((BsonElement)element.Tag);
                        document.Add((BsonElement)newValues);
                    }
                    else
                    {
                        document.Set(index, ((BsonDocument)newValues));
                    }

                    newValues = element.Parent.Tag;
                }
                else
                {
                    var document = (BsonElement) (element.Parent.Tag);

                    if (document.Value is BsonArray)
                    {
                        var arr = document.Value.AsBsonArray;
                        var value = (BsonValue)element.Tag;
                        int index = arr.IndexOf(value);

                        if (newValues is BsonElement)
                        {
                            arr.Remove(value);
                            arr.Add(newValues as BsonValue);
                        }
                        else
                        {
                            arr[index] = ((BsonValue)newValues);
                        }

                        newValues = element.Parent.Tag;
                    }
                    else
                    {
                        var arr = document.Value.AsBsonDocument;
                        var value = (BsonElement)element.Tag;
                        arr.RemoveElement(value);
                        arr.Add((BsonElement)newValues);
                        newValues = element.Parent.Tag;
                    }
                }
            }
            else if (element.Parent.Tag is BsonDocument)
            {
                int index = ((BsonDocument)element.Parent.Tag).IndexOfName(((BsonElement)element.Tag).Name);

                if (newValues is BsonElement)
                {
                    ((BsonDocument)element.Parent.Tag).RemoveElement((BsonElement)element.Tag);
                    ((BsonDocument)element.Parent.Tag).Add((BsonElement)newValues);
                }
                else if (newValues is BsonArray)
                {
                    ((BsonDocument)element.Parent.Tag).Set(index, ((BsonArray)newValues));
                }
                else
                {
                    ((BsonDocument)element.Parent.Tag).Set(index, ((BsonDocument)newValues));
                }

                newValues = element.Parent.Tag;
            }

            return ReplaceParent(element.Parent, newValues);
        }

        private TreeNode DeleteNodeFromParent(TreeNode element, object currentElement = null)
        {
            if (element.Parent == null)
            {
                return element;
            }
            if (element.Parent.Tag is BsonElement)
            {
                if (element.Parent.Tag is BsonArray)
                {
                    var array = ((BsonElement)element.Parent.Tag).Value;
                    var arrayContainer = array.AsBsonArray;
                    var bsonElement = (BsonValue)element.Tag;
                    array.AsBsonArray.Remove(bsonElement);
                    currentElement = element.Parent.Tag;
                }
                else if (element.Parent.Tag is BsonDocument)
                {
                    var document = ((BsonElement)element.Parent.Tag).Value.AsBsonDocument;
                    int index = document.IndexOfName(((BsonElement)element.Tag).Name);
                    document.RemoveAt(index);
                    currentElement = element.Parent.Tag;
                }
                else
                {
                    var document = (BsonElement)(element.Parent.Tag);

                    if (document.Value is BsonArray)
                    {
                        var arr = document.Value.AsBsonArray;
                        var value = (BsonValue)element.Tag;
                        arr.Remove(value);
                        currentElement = element.Parent.Tag;
                    }
                    else
                    {
                        var arr = document.Value.AsBsonDocument;
                        var value = (BsonElement)element.Tag;
                        arr.RemoveElement(value);
                        currentElement = element.Parent.Tag;
                    }
                }
            }
            else if (element.Parent.Tag is BsonDocument)
            {
                ((BsonDocument)element.Parent.Tag).RemoveElement((BsonElement)element.Tag);
                currentElement = element.Parent.Tag;
            }

            return ReplaceParent(element.Parent, currentElement);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode parent = FindParentDocument(PanelSelectedElement);
            BsonDocument parentDocument = (BsonDocument) parent.Tag.ToBsonDocument().DeepClone();

            BsonValue newBsonValue;
            switch (changeTypeComboBox.Text.ToString())
            {
                case "String":
                    newBsonValue = new BsonString(ValueEditTextBox.Text.ToString());
                    break;
                case "Int32":
                    int i = Convert.ToInt32(ValueEditTextBox.Text);
                    newBsonValue = new BsonInt32(i);
                    break;
                case "Document":
                    newBsonValue = ((BsonDocument)PanelSelectedElement.Tag);
                    break;
                default:
                    newBsonValue = ((BsonElement)PanelSelectedElement.Tag).Value;
                    break;
            }

            var newElement = new BsonElement(NameEditTextBox.Text.ToString(), newBsonValue);

            TreeNode parentReplaced = ReplaceParent(PanelSelectedElement, newElement);
            BsonDocument parentDocumentReplaced = ((BsonDocument)parentReplaced.Tag);
     
            var updateDoc = currentCollection.FindOneAndReplace(parentDocument, parentDocumentReplaced);
            
            int treeNodeIndex = PanelSelectedElement.Parent.Nodes.IndexOf(PanelSelectedElement);
            if (treeNodeIndex != -1)
            {
                PanelSelectedElement.Parent.Nodes[treeNodeIndex] = CreateTreeNode(newElement);
                PanelSelectedElement.Parent.Nodes.Remove(PanelSelectedElement);
                Notify("Your changes has been updated.", "Your changes has been updated in database.", 3);
            }
            else
            {
                Notify("There some error.", "Try to reload data in collection view and retry.", error: true);
            }
        }

        public void addElement(TreeNode element, BsonElement tag)
        {
            PanelSelectedElement = CollectionView.SelectedNode;
            string nodeName = PanelSelectedElement.Text;
            TreeNode parent = FindParentDocument(PanelSelectedElement);
            BsonDocument parentDocument = (BsonDocument)parent.Tag.ToBsonDocument().DeepClone();
            BsonValue newBsonValue;
            TreeNode parentReplaced;

            if (((BsonElement)PanelSelectedElement.Tag).Value is BsonArray)
            {
                newBsonValue = (tag).Value;
                parentReplaced = ReplaceParent(PanelSelectedElement, newBsonValue);
            }
            else if (((BsonElement)PanelSelectedElement.Tag).Value is BsonDocument)
            {
                parentReplaced = ReplaceParent(PanelSelectedElement, tag);
            }
            else
            {
                Notify("There some error.", "Try to reload data in collection view and retry.", error: true);
                return;
            }

            BsonDocument parentDocumentReplaced = ((BsonDocument)parentReplaced.Tag);

            var updateDoc = currentCollection.FindOneAndReplace(parentDocument, parentDocumentReplaced);

            TreeNode newNode = CreateTreeNode(tag);
            int index = CollectionView.Nodes.IndexOf(CollectionView.SelectedNode);
            CollectionView.SelectedNode.Parent.Nodes.Remove(CollectionView.SelectedNode);
            newNode.Text = nodeName;
            CollectionView.SelectedNode.Parent.Nodes.Insert(index, newNode); 
                
            PanelSelectedElement = newNode;
            CollectionView.SelectedNode = newNode;
            CollectionView.SelectedNode.BackColor = Color.MediumSeaGreen;
            Notify("Your changes has been updated.", "Your changes has been updated in database.", 3);
        }

        public void addElement(TreeNode element, object tag)
        {
            PanelSelectedElement = CollectionView.SelectedNode;
            TreeNode parent = FindParentDocument(PanelSelectedElement);
            BsonDocument parentDocument = (BsonDocument)parent.Tag.ToBsonDocument().DeepClone();

            BsonValue newBsonValue;
            TreeNode parentReplaced;
            BsonDocument parentDocumentReplaced;
            TreeNode newNode;

            if (PanelSelectedElement.Tag is BsonArray)
            {
                newBsonValue = ((BsonValue)tag);
                parentReplaced = ReplaceParent(PanelSelectedElement, newBsonValue);
                parentDocumentReplaced = ((BsonDocument)parentReplaced.Tag);
                newNode = CreateTreeNode((BsonValue)tag);
            }
            else if ((PanelSelectedElement.Tag) is BsonDocument)
            {
                parentReplaced = ReplaceParent(PanelSelectedElement, tag);
                parentDocumentReplaced = tag as BsonDocument;
                newNode = CreateTreeNode((BsonValue)tag);
            }
            else if (PanelSelectedElement.Tag is BsonElement)
            {
                string selectedElementText = PanelSelectedElement.Text;
                parentReplaced = ReplaceParent(PanelSelectedElement, ((BsonDocument)tag).Values);
                parentDocumentReplaced = ((BsonDocument)parentReplaced.Tag);
                newNode = CreateTreeNode((BsonValue)tag);
                newNode.Text = selectedElementText;
            }
            else
            {
                Notify("There some error.", "Try to reload data in collection view and retry.", error: true);
                return;
            }

            var updateDoc = currentCollection.FindOneAndReplace(parentDocument, parentDocumentReplaced);

            if (CollectionView.SelectedNode.Parent != null)
            {
                int index = CollectionView.SelectedNode.Parent.Nodes.IndexOf(CollectionView.SelectedNode);
                CollectionView.SelectedNode.Parent.Nodes.Remove(CollectionView.SelectedNode);
                CollectionView.SelectedNode.Parent.Nodes.Insert(index, newNode);
            } else
            {
                int index = CollectionView.Nodes.IndexOf(CollectionView.SelectedNode);
                CollectionView.Nodes.Remove(CollectionView.SelectedNode);
                newNode.Text = index + ": Object";
                CollectionView.Nodes.Insert(index, newNode);
            }

            PanelSelectedElement = newNode;
            CollectionView.SelectedNode = newNode;
            CollectionView.SelectedNode.BackColor = Color.MediumSeaGreen;
            Notify("Your changes has been updated.", "Your changes has been updated in database.", 3);
            return;
        }

        async private void Notify(string title, string description, double duration = 3, bool error = false)
        {
            if (error)
            {
                NotificationPanel.BackColor = Color.LightCoral;
            }
            else
            {
                NotificationPanel.BackColor = Color.MediumSeaGreen;
            }
            this.NotificationText.Text = title;
            this.Description.Text = description;
            this.NotificationPanel.Visible = true;
            await Task.Run(() => HideNotifyPanel(NotificationPanel, duration));
        }

        private void HideNotifyPanel(Panel notificationPanel, double duration)
        {
            System.Threading.Thread.Sleep((int)duration * 1000);
            notificationPanel.Invoke(
                new MethodInvoker(
                    delegate
                    {
                        notificationPanel.Visible = false;
                    }
                )
            );
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add form = new Add((TreeNode)PanelSelectedElement.Clone(), this);
            form.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            PanelSelectedElement = CollectionView.SelectedNode;
            TreeNode parent = FindParentDocument(PanelSelectedElement);
            BsonDocument parentDocument = (BsonDocument)parent.Tag.ToBsonDocument().DeepClone();
            TreeNode parentWithoutNode= DeleteNodeFromParent(CollectionView.SelectedNode);
            BsonDocument parentDocumentWithoutNode = parentWithoutNode.Tag as BsonDocument;

            if (CollectionView.SelectedNode.Parent != null)
            {
                var updateDoc = currentCollection.FindOneAndReplace(parentDocument, parentDocumentWithoutNode);
                int index = CollectionView.SelectedNode.Parent.Nodes.IndexOf(CollectionView.SelectedNode);
                CollectionView.SelectedNode.Parent.Nodes.Remove(CollectionView.SelectedNode);
            }
            else
            {
                var updateDoc = currentCollection.FindOneAndDelete(parentDocument);
            }

            CollectionView.SelectedNode = null;
        }

        private void addNewObject_Click(object sender, EventArgs e)
        {
            BsonDocument newDocument = new BsonDocument();
            currentCollection.InsertOne(newDocument);

            var treeNode = new TreeNode();
            treeNode.Expand();
            treeNode.Text = CollectionView.Nodes.Count + ": Object";
            treeNode.BackColor = Color.Honeydew;
            treeNode.Tag = newDocument;

            CollectionView.Nodes.Add(treeNode);
        }
     }
}
