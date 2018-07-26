using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EsofaCommon
{
    public static  class TreeViewNodesCheckState
    {
        //方法一：
        #region
        public static void ParentChildNodeCheck(TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count > 0)
                {
                    bool NoFalse = true;
                    foreach (TreeNode tn in e.Node.Nodes)
                    {
                        if (tn.Checked == false)
                        {
                            NoFalse = false;
                        }
                    }
                    if (e.Node.Checked == true || NoFalse)
                    {
                        foreach (TreeNode tn in e.Node.Nodes)
                        {
                            if (tn.Checked != e.Node.Checked)
                            {
                                tn.Checked = e.Node.Checked;
                            }
                        }
                    }
                }
                if (e.Node.Parent != null && e.Node.Parent is TreeNode)
                {                   
                    bool ParentNode = true;
                    foreach (TreeNode tn in e.Node.Parent.Nodes)
                    {
                        if (tn.Checked == false)
                        {
                            ParentNode = false;
                        }
                    }
                    if (e.Node.Parent.Checked != ParentNode && (e.Node.Checked == false || e.Node.Checked == true && e.Node.Parent.Checked == false))
                    {
                        e.Node.Parent.Checked = ParentNode;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        //public static void UpdateChildNodes(TreeNode node)
        //{
        //    foreach (TreeNode child in node.Nodes)
        //    {
        //        child.Checked = node.Checked;
        //        child.ForeColor = Color.Black;
        //        UpdateChildNodes(child);
        //    }
        //}

        //public static void UpdateParents(TreeNode node)
        //{
        //    var parent = node.Parent;
        //    while (parent != null)
        //    {
        //        //设置父节点状态
        //        SetNodeState(parent);
        //        parent = parent.Parent;
        //    }
        //}


        //public static void SetNodeState(TreeNode parent)
        //{
        //    if(parent.Checked)// (parent.Nodes.IsAllChecked())
        //    {

        //        //子节点全选中
        //        parent.Checked = true;
        //        parent.ForeColor = Color.Black;
        //    }
        //    else if (!parent.Checked)//(parent.Nodes.IsAllUnChecked())
        //    {
        //        //子节点全未选中
        //        parent.Checked = false;
        //        parent.ForeColor = Color.Black;
        //        //还要判断子节点中是否有半选中状态
        //        foreach (TreeNode child in parent.Nodes)
        //        {
        //            if (child.ForeColor == Color.Blue)
        //            {
        //                //用蓝色标记半选中状态
        //                parent.ForeColor = Color.Blue;
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        //子节点有的选中有的未选中
        //        parent.Checked = false;
        //        parent.ForeColor = Color.Blue;
        //    }
        //}
        //public static void DrawNode(object sender, DrawTreeNodeEventArgs e)
        //{
        //    if (e.Bounds.Location.X <= 0)
        //    {
        //        return;
        //    }

        //    var treeview = sender as TreeView;
        //    var brush = Brushes.Black;
        //    if (e.Node.ForeColor == Color.Blue)
        //    {
        //        var location = e.Node.Bounds.Location;
        //        location.Offset(-11, 2);
        //        var size = new Size(9, 9);
        //        brush = Brushes.Blue;
        //        e.Graphics.FillRectangle(brush, new Rectangle(location, size));
        //    }
        //    //绘制文本
        //    e.Graphics.DrawString(e.Node.Text, treeview.Font, brush, e.Bounds.Left, e.Bounds.Top);
        //}



        //设置子节点状态

        #region
        public static void SetChildNodeCheckedState(TreeNode currNode, bool isCheckedOrNot)
        {
            if (currNode.Nodes == null) return; //没有子节点返回
            foreach (TreeNode tmpNode in currNode.Nodes)
            {
                tmpNode.Checked = isCheckedOrNot;
                SetChildNodeCheckedState(tmpNode, isCheckedOrNot);
            }
        }

        //设置父节点状态
        public static void SetParentNodeCheckedState(TreeNode currNode, bool isCheckedOrNot)
        {
            if (currNode.Parent == null) return; //没有父节点返回
            if (isCheckedOrNot) //如果当前节点被选中，则设置所有父节点都被选中
            {
                currNode.Parent.Checked = isCheckedOrNot;
                SetParentNodeCheckedState(currNode.Parent, isCheckedOrNot);
            }
            else //如果当前节点没有被选中，则当其父节点的子节点有一个被选中时，父节点被选中，否则父节点不被选中
            {
                bool checkedFlag = false;
                foreach (TreeNode tmpNode in currNode.Parent.Nodes)
                {
                    if (tmpNode.Checked)
                    {
                        checkedFlag = true;
                        break;
                    }
                }
                currNode.Parent.Checked = checkedFlag;
                SetParentNodeCheckedState(currNode.Parent, checkedFlag);
            }
        }
        #endregion

        //方法三：
        /// <summary>
        /// 系列节点 Checked 属性控制
        /// </summary>
        /// <param name="e"></param>
        public static void CheckControl(TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node != null && !Convert.IsDBNull(e.Node))
                {
                    CheckParentNode(e.Node);
                    if (e.Node.Nodes.Count > 0)
                    {
                        CheckAllChildNodes(e.Node, e.Node.Checked);
                    }
                }
            }
        }

        #region 私有方法

        //改变所有子节点的状态
        private static void CheckAllChildNodes(TreeNode pn, bool IsChecked)
        {
            foreach (TreeNode tn in pn.Nodes)
            {
                tn.Checked = IsChecked;

                if (tn.Nodes.Count > 0)
                {
                    CheckAllChildNodes(tn, IsChecked);
                }
            }
        }

        //改变父节点的选中状态，此处为所有子节点不选中时才取消父节点选中，可以根据需要修改
        private static void CheckParentNode(TreeNode curNode)
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
