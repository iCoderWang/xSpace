﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EsofaCommon
{
    public  class TreeViewNodesCheckStateSetting
    {
        List<string> lstTgtName = new List<string>();
        /// <summary>
        /// 系列节点 Checked 属性控制
        /// </summary>
        /// <param name="e"></param>
        public void Set(TreeViewEventArgs e, out int counter, out List<string> lst)
        {
            counter = 0;
            lst = new List<string>();
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node != null && !Convert.IsDBNull(e.Node))
                {
                    CheckParentNode(e.Node);
                    if (e.Node.Nodes.Count > 0)
                    {
                        CheckAllChildNodes(e.Node, e.Node.Checked);
                    }
                    if (e.Node.Nodes.Count == 0 && e.Node.Text !="")
                    {
                        if (e.Node.Level == 2 && e.Node.Checked == true && !lstTgtName.Contains(e.Node.Text))
                        {
                            lstTgtName.Add(e.Node.Text);
                        }
                        if (e.Node.Level == 2 && e.Node.Checked == false && lstTgtName.Contains(e.Node.Text))
                        {
                            lstTgtName.Remove(e.Node.Text);
                        }

                    }
                }
            }
            counter++;
            lst = lstTgtName;
        }

        #region 私有方法

        //改变所有子节点的状态
        private  void CheckAllChildNodes(TreeNode pn, bool IsChecked )
        {
            foreach (TreeNode tn in pn.Nodes)
            {
                tn.Checked = IsChecked;

                if (tn.Nodes.Count > 0)
                {
                    CheckAllChildNodes(tn, IsChecked);
                }
                if(tn.Nodes.Count == 0)
                {
                    if (tn.Level == 2 && tn.Checked == true && !lstTgtName.Contains(tn.Text))
                    {
                        lstTgtName.Add(tn.Text);
                    }
                    if (tn.Level == 2 && tn.Checked == false && lstTgtName.Contains(tn.Text))
                    {
                        lstTgtName.Remove(tn.Text);
                    }

                }
            }
        }

        //改变父节点的选中状态，此处为所有子节点不选中时才取消父节点选中，可以根据需要修改
        private void CheckParentNode(TreeNode curNode)
        {
            bool bChecked = false;

            if (curNode.Parent != null)
            {
                foreach (TreeNode node in curNode.Parent.Nodes)
                {
                    if (node.Checked)
                    {
                        bChecked = true;
                        break;
                    }
                }

                if (bChecked)
                {
                    curNode.Parent.Checked = true;
                    CheckParentNode(curNode.Parent);
                }
                else
                {
                    curNode.Parent.Checked = false;
                    CheckParentNode(curNode.Parent);
                }
            }
        }
        #endregion
    }
}
