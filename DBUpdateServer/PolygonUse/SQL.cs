﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonUse
{
    public static class SQL
    {
        private static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IFTEV0K;Initial Catalog=JudgementApp;Integrated Security=True;Pooling=False");// ReadCS().ToString()); 
                                                                                                                                                                 //  private static SqlConnection con = new SqlConnection(@"Server =WIN-U0806780LB2\SQLEXPRESS; Database=POS_CARWASH;User ID = sa; pwd=123");// ReadCS().ToString()); 

        //public static String DataSource = ReadCS();
        //private static SqlConnection con = new SqlConnection(DataSource);// ReadCS().ToString()); 
        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public static SqlConnection Con
        {

            get
            {
                return con;
            }
        }

     
        public static String ScalarQuery(String Query)
        {
            String Result = string.Empty;
            try
            {

                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                Result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Scalar Query" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return Result;
        }
        public static bool NonScalarQuery(String Query)
        {
            bool queryStatus = false;
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                queryStatus = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return queryStatus;
        }
        public static DataTable GetDataTable(string Query)
        {
            if (SQL.Con.State == ConnectionState.Open)
            {
                SQL.Con.Close();
            }
            SQL.Con.Open();
            DataTable datasheets = new DataTable();
            SqlCommand command = new SqlCommand(Query, SQL.Con);
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(datasheets);
            adapter.Dispose();
            return datasheets;
        }
    }
}
