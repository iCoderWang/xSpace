﻿using EsofaModel;
using System.Collections.Generic;
using System.Data;
using EsofaCommon;

namespace EsofaDAL
{
    public partial class RawDataDAL
    {
        public List <TargetEntity> GetList()
        {
            string sql = "select * from target";
            DataTable dt = MySqlHelper.GetDataTable(sql,CommandType.Text);
            DataAssignment dA = new DataAssignment();
            List<TargetEntity> list = new List<TargetEntity>();
            return dA.AssignFromDb(list,dt);
            
        }
        public List<TargetEntity> GetList(string sql)
        {
            //string sql = "select * from target";
            DataTable dt = MySqlHelper.GetDataTable(sql, CommandType.Text);
            DataAssignment dA = new DataAssignment();
            List<TargetEntity> list = new List<TargetEntity>();
            return dA.AssignFromDb(list, dt);

        }

        public int Insert(string sql)
        {
            int rowCount = MySqlHelper.ExecuteNonQuery(sql, CommandType.Text);
            return rowCount;
        }

        public void ExecuteCmd(string sql)
        {
            MySqlHelper.ExecuteCommand(sql, CommandType.Text);
        }
    }
}
