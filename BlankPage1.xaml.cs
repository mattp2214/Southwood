using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data.SqlClient;
using Windows.UI.Composition;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Southwood
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    

    public sealed partial class BlankPage1 : Page
    {


        
       

        

        public BlankPage1()
        {
            InitializeComponent();
            string ConnectionString;
            SqlConnection cnn;
            ConnectionString = "Data Source=mainlocal.database.windows.net;Initial Catalog = Southwood; User ID = team6; Password=nixeus22!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            cnn = new SqlConnection(ConnectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            
            command = new SqlCommand("INSERT INTO JOBS (JobName)" + "VALUES (ECU)");

            adapter.InsertCommand = command;

            

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionString;
            SqlConnection cnn;
            ConnectionString = "Data Source=mainlocal.database.windows.net;Initial Catalog = Southwood; User ID = team6; Password=nixeus22!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";


            sql = "SELECT TOP(1000) *FROM[dbo].[JOBS]";
            command = new SqlCommand(sql, cnn);


            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output += dataReader.GetValue(1);
            }
            
            txtConnectionStatus.Text = Output;

        }

        private void txtConnectionStatus_SelectionChanged(object sender, RoutedEventArgs e)
        {
            


        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            
        }


        
    }

}



    

