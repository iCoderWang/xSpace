using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsofaModel;

namespace EsofaCommon
{
    public class TargetListTransfomer
    {
        /// <summary>
        /// 目标区(Target)数据格式转化为远景区(Basin)目标格式
        /// </summary>
        /// <param name="lst_Tgt"></param>
        /// <param name="lst_Bsn"></param>
        /// <returns></returns>
       public List<AverageValuesBasinEntity> ToBasin(List<AverageValuesTargetEntity> lst_Tgt,
           List<AverageValuesBasinEntity> lst_Bsn)
        {
            //= new List<AverageValuesBasinEntity>();
            foreach (AverageValuesTargetEntity avte in lst_Tgt)
            {
                lst_Bsn.Add(new AverageValuesBasinEntity
                {
                    tgt_Att_Sn = avte.tgt_Att_Sn,
                    tgt_Att_Name = avte.tgt_Att_Name,
                    bsn_Att_Name = avte.bsn_Att_Name,
                    bsn_Att_Ps = avte.tgt_Att_Ps,
                    bsn_Att_Para_Sc = avte.tgt_Att_Para_Sc,
                    bsn_Att_Para_Gr = avte.tgt_Att_Para_Gr_Avg,
                    bsn_Geo_Para_TrRoms = avte.tgt_Geo_Para_TrRoms_Avg,
                    bsn_Geo_Para_Toc = avte.tgt_Geo_Para_Toc_Avg,
                    bsn_Geo_Para_Kt = avte.tgt_Geo_Para_Kt,
                    bsn_Geo_Para_Ro = avte.tgt_Geo_Para_Ro_Avg,
                    bsn_Geo_Para_Ea = avte.tgt_Geo_Para_Ea,
                    bsn_Geo_Para_Rr = avte.tgt_Geo_Para_Rr_Avg,
                    bsn_Geo_Para_Scd = avte.tgt_Geo_Para_Scd,
                    bsn_Eng_Para_Dr = avte.tgt_Eng_Para_Dr_Avg,
                    bsn_Eng_Para_Bmc = avte.tgt_Eng_Para_Bmc_Avg,
                    tgt_Att_Id = avte.tgt_Att_Id
                });
            }    
            return lst_Bsn;
        }

        public List<AverageValuesBlockEntity> ToBlock(List<AverageValuesTargetEntity> lst_Tgt, 
            List<AverageValuesBlockEntity> lst_Blk)
        {
            foreach(AverageValuesTargetEntity avte in lst_Tgt)
            {
                lst_Blk.Add(new AverageValuesBlockEntity
                {
                    tgt_Att_Sn = avte.tgt_Att_Sn,
                    tgt_Att_Name = avte.tgt_Att_Name,
                    bsn_Att_Name = avte.bsn_Att_Name,
                    blk_Att_Ps = avte.tgt_Att_Ps,
                    blk_Att_Para_Sc = avte.tgt_Att_Para_Sc,
                    blk_Att_Para_Gr = avte.tgt_Att_Para_Gr_Avg,
                    blk_Geo_Para_TrRoms = avte.tgt_Geo_Para_TrRoms_Avg,
                    blk_Geo_Para_Toc = avte.tgt_Geo_Para_Toc_Avg,
                    blk_Geo_Para_Kt = avte.tgt_Geo_Para_Kt,
                    blk_Geo_Para_Ro = avte.tgt_Geo_Para_Ro_Avg,
                    blk_Geo_Para_Ea = avte.tgt_Geo_Para_Ea,
                    blk_Geo_Para_Gc = avte.tgt_Geo_Para_Gc_Avg,
                    blk_Geo_Para_Rr = avte.tgt_Geo_Para_Rr_Avg,
                    blk_Geo_Para_Por = avte.tgt_Geo_Para_Por_Avg,
                    blk_Geo_Para_Scd = avte.tgt_Geo_Para_Scd,
                    blk_Eng_Para_Dr = avte.tgt_Eng_Para_Dr_Avg,
                    blk_Eng_Para_Pc = avte.tgt_Eng_Para_Pc_Avg,
                    blk_Eng_Para_Bmc = avte.tgt_Eng_Para_Bmc_Avg,
                    blk_Mkt_Para_Sg = avte.tgt_Mkt_Para_Sg,
                    tgt_Att_Id = avte.tgt_Att_Id
                });
            }
            return lst_Blk;
        }
    }
}
