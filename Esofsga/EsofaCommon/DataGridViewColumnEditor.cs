﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsofaCommon
{
    public partial class DataGridViewColumnEditor
    {
        public void ColumHeaderEdit(DataGridView dgv, string dgvName)
        {
            dgv.AutoGenerateColumns = true;
            dgv.Name = dgvName;
            //if(dgvName == "dgvBasin")
            //{
            //    dgv.Columns[0].HeaderText = "盆地名称";
            //    dgv.Columns[1].HeaderText = "主力层系";
            //    dgv.Columns[2].HeaderText = "保存条件";
            //    dgv.Columns[3].HeaderText = "地质资源量";
            //    dgv.Columns[4].HeaderText = "富有机质页岩厚度";
            //    dgv.Columns[5].HeaderText = "TOC(%)";
            //    dgv.Columns[6].HeaderText = "干酪根类型";
            //    dgv.Columns[7].HeaderText = "Ro(%)";
            //    dgv.Columns[8].HeaderText = "有效圈定面积";
            //    dgv.Columns[9].HeaderText = "资源丰度";
            //    dgv.Columns[10].HeaderText = "构造复杂度";
            //    dgv.Columns[11].HeaderText = "埋深范围";
            //    dgv.Columns[12].HeaderText = "脆性矿物含量";
            //}
            //else if(dgvName == "dgvBlock")
            //{
            //    dgv.Columns[0].HeaderText = "区块名称";
            //    dgv.Columns[1].HeaderText = "盆地名称";
            //    dgv.Columns[2].HeaderText = "主力层系";
            //    dgv.Columns[3].HeaderText = "保存条件";
            //    dgv.Columns[4].HeaderText = "地质资源量";
            //    dgv.Columns[5].HeaderText = "富有机质页岩厚度";
            //    dgv.Columns[6].HeaderText = "TOC(%)";
            //    dgv.Columns[7].HeaderText = "干酪根类型";
            //    dgv.Columns[8].HeaderText = "Ro(%)";
            //    dgv.Columns[9].HeaderText = "有效圈定面积";
            //    dgv.Columns[10].HeaderText = "含气量";
            //    dgv.Columns[11].HeaderText = "资源丰度";
            //    dgv.Columns[12].HeaderText = "孔隙度(%)";
            //    dgv.Columns[13].HeaderText = "构造复杂度";
            //    dgv.Columns[14].HeaderText = "埋深范围";
            //    dgv.Columns[15].HeaderText = "压力系数";
            //    dgv.Columns[16].HeaderText = "脆性矿物含量";
            //    dgv.Columns[17].HeaderText = "地表地貌";
            //}
             if(dgvName == "dgvTarget")
            {
                dgv.Columns[0].HeaderText = "目标区";
                dgv.Columns[1].HeaderText = "盆地";
                dgv.Columns[2].HeaderText = "主力层系";
                dgv.Columns[3].HeaderText = "保存条件";
                dgv.Columns[4].HeaderText = "最小_地质资源量/r/h(万亿方)";
                dgv.Columns[5].HeaderText = "最大_地质资源量/r/h(万亿方)";
                dgv.Columns[6].HeaderText = "最小_富有机质页岩厚度";
                dgv.Columns[7].HeaderText = "最大_富有机质页岩厚度";
                dgv.Columns[8].HeaderText = "最小_TOC(%)";
                dgv.Columns[9].HeaderText = "最大_TOC(%)";
                dgv.Columns[10].HeaderText = "干酪根类型";
                dgv.Columns[11].HeaderText = "最小_Ro(%)";
                dgv.Columns[12].HeaderText = "最大_Ro(%)";
                dgv.Columns[13].HeaderText = "有效圈定面积";
                dgv.Columns[14].HeaderText = "最小_含气量";
                dgv.Columns[15].HeaderText = "最大_含气量";
                dgv.Columns[16].HeaderText = "最小_资源丰度";
                dgv.Columns[17].HeaderText = "最大_资源丰度";
                dgv.Columns[18].HeaderText = "最小_孔隙度(%)";
                dgv.Columns[19].HeaderText = "最大_孔隙度(%)";
                dgv.Columns[20].HeaderText = "构造复杂度";
                dgv.Columns[21].HeaderText = "顶底板岩性";
                dgv.Columns[22].HeaderText = "最小_埋深范围";
                dgv.Columns[23].HeaderText = "最大_埋深范围";
                dgv.Columns[24].HeaderText = "最小_压力系数";
                dgv.Columns[25].HeaderText = "最大_压力系数";
                dgv.Columns[26].HeaderText = "渗透率";
                dgv.Columns[27].HeaderText = "裂缝发育度";
                dgv.Columns[28].HeaderText = "最小_主应力差异系数";
                dgv.Columns[29].HeaderText = "最大_主应力差异系数";
                dgv.Columns[30].HeaderText = "最小_脆性矿物含量";
                dgv.Columns[31].HeaderText = "最大_脆性矿物含量";
                dgv.Columns[32].HeaderText = "水系";
                dgv.Columns[33].HeaderText = "区域勘探度";
                dgv.Columns[34].HeaderText = "市场气价";
                dgv.Columns[35].HeaderText = "市场需求";
                dgv.Columns[36].HeaderText = "交通设施";
                dgv.Columns[37].HeaderText = "管网条件";
                dgv.Columns[38].HeaderText = "地表地貌";
            }
        }
    }
}
