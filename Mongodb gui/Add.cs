using MongoDB.Bson;
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
    public partial class Add : Form
    {
        TreeNode node;
        BsonType type;
        Form parent;

        public Add(TreeNode selected, Form parent)
        {
            node = (TreeNode)selected.Clone();
            this.parent = parent;

            if (node.Tag is BsonElement)
            {
                type = ((BsonElement)node.Tag).Value.BsonType;
            }
            else
            {
                type = ((BsonValue)node.Tag).BsonType;
            }

            InitializeComponent();
        }

        public void SetUI()
        {
            if (type == BsonType.Array)
            {
                AddToArrayPanel.Visible = true;
                AddDocumentPanel.Visible = false;
            }
            else if (type == BsonType.Document)
            {
                AddDocumentPanel.Visible = true;
                AddToArrayPanel.Visible = false;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            BsonValue newValue;

            if (type == BsonType.Array)
            {
                switch (comboBox1.SelectedItem)
                {
                    case "String":
                        newValue = new BsonString(inputValueForArrayElement.Text);
                        break;
                    case "Int32":
                        int i = Convert.ToInt32(inputValueForArrayElement.Text);
                        newValue = new BsonInt32(i);
                        break;
                    case "Document":
                        newValue = new BsonDocument();
                        break;
                    case "Array":
                        newValue = new BsonArray();
                        break;
                    default:
                        newValue = null;
                        break;
                }
                if (node.Tag is BsonElement)
                {
                    BsonElement tag = ((BsonElement)node.Tag).DeepClone();
                    BsonArray arr = (BsonArray)tag.Value;

                    if (newValue != null)
                    {
                        arr.Add(newValue);
                        if (parent is MainForm)
                        {
                            ((MainForm)parent).addElement(node, tag);
                        }
                        else if (parent is ViewCollection)
                        {
                            ((ViewCollection)parent).addElement(node, tag);
                        }
                    }
                }
                else if (node.Tag is BsonValue)
                {
                    BsonValue tag = ((BsonValue)node.Tag).DeepClone();
                    BsonArray arr = (BsonArray)tag;

                    if (newValue != null)
                    {
                        arr.Add(newValue);
                        if (parent is MainForm)
                        {
                            ((MainForm)parent).addElement(node, tag);
                        }
                        else if (parent is ViewCollection)
                        {
                            ((ViewCollection)parent).addElement(node, tag);
                        }
                    }
                }
            }
            else if (type == BsonType.Document)
            {
                switch (comboBox1.SelectedItem)
                {
                    case "String":
                        newValue = new BsonString(documentPropertyValue.Text);
                        break;
                    case "Int32":
                        int i = Convert.ToInt32(documentPropertyValue.Text);
                        newValue = new BsonInt32(i);
                        break;
                    case "Document":
                        newValue = new BsonDocument();
                        break;
                    case "Array":
                        newValue = new BsonArray();
                        break;
                    default:
                        newValue = null;
                        break;
                }

                if (node.Tag is BsonDocument) {
                    BsonElement newEl = new BsonElement(documentPropertyName.Text, newValue);
                    BsonDocument tag = (BsonDocument)node.Tag;
                    tag = tag.DeepClone() as BsonDocument;
                    tag.Add(newEl);
                    if (parent is MainForm)
                    {
                        ((MainForm)parent).addElement(node, tag);
                    } else if (parent is ViewCollection)
                    {
                        ((ViewCollection)parent).addElement(node, tag);
                    }
                    
                }
                else if (node.Tag is BsonElement)
                {
                    BsonElement tag = ((BsonElement)node.Tag).DeepClone();
                    BsonElement newEl = new BsonElement(documentPropertyName.Text, newValue);
                    tag.Value.AsBsonDocument.Add(newEl);
                    if (parent is MainForm)
                    {
                        ((MainForm)parent).addElement(node, tag);
                    }
                    else if (parent is ViewCollection)
                    {
                        ((ViewCollection)parent).addElement(node, tag);
                    }
                }
            }

            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Array" || comboBox1.SelectedItem.ToString() == "Document")
            {
                inputValueForArrayElement.Enabled = false;
                inputValueForArrayElement.Text = "";
            }
            else
            {
                inputValueForArrayElement.Enabled = true;
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            SetUI();
        }
    }
}
