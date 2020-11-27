using APIBanDienThoai.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIBanDienThoai.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace APIBanDienThoai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool isClick { get; set; }
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            update_DataGridView();
        }
        private async void update_DataGridView()
        {
            button_product.BackColor = Color.White;
            button_customer.BackColor = Color.White;
            button_Brand.BackColor = Color.Orange;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            string url = GlobalVariable.url + "api/brand";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<BRAND>>(json);
            dataGridView1.DataSource = list;
            dataGridView1.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa Brand";
            btn_Xoa.UseColumnTextForButtonValue = true;

        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ///MessageBox.Show(" "+ e.ColumnIndex + ", " + e.RowIndex);
            if (e.ColumnIndex == 5 && this.button_Brand.BackColor == Color.Orange)
            {
                var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string url = GlobalVariable.url + "api/brand/delete?id=" + idBrand;
                DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Brand hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                        client.BaseAddress = new Uri(url);
                        var response = await client.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xoa Thanh Cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Khong Thanh Cong");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Unknow
                }
                update_DataGridView();
            }
            if (e.ColumnIndex == 4 && this.button_Brand.BackColor == Color.Orange)
            {
                if (isClick == false)
                {
                    DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[1];
                    dataGridView1.CurrentCell = cell;
                    dataGridView1.ReadOnly = false;
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        for(int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            if (row.Index != e.RowIndex || i != 1)
                                row.Cells[i].ReadOnly = true;
                            else {
                                row.Cells[i].ReadOnly = false;
                            }
                        }
                    }
                    isClick = true;
                }
                else
                {
                    var newBrandName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //MessageBox.Show(newBrandName);
                    var json = JsonConvert.SerializeObject(new BRAND() { BrandName = newBrandName});
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string url = GlobalVariable.url + "api/brand/update?id=" + idBrand;

                    try
                    {
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                        client.BaseAddress = new Uri(url);

                        var response = await client.PutAsync(url, data);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Update thanh cong");
                            
                        }
                        else
                        {
                            MessageBox.Show("Update khong thanh cong");
                        }
                        update_DataGridView();
                    }
                    catch
                    {
                        MessageBox.Show("Update khong thanh cong");
                        update_DataGridView();
                    }
                    isClick = false;
                }
            }
            // delete product
            if (e.ColumnIndex == 9  && this.button_product.BackColor == Color.Orange)
            {
                var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string url = GlobalVariable.url + "api/product/delete?id=" + idBrand;
                DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Brand hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                        client.BaseAddress = new Uri(url);
                        var response = await client.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xoa Thanh Cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Khong Thanh Cong");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Unknow
                }
                update_DataGridView_Product();
            }

            // delete Customer
            if (e.ColumnIndex == 13 && this.button_customer.BackColor == Color.Orange)
            {
                var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string url = GlobalVariable.url + "api/customer/delete?id=" + idBrand;
                DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Brand hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                        client.BaseAddress = new Uri(url);
                        var response = await client.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xoa Thanh Cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Khong Thanh Cong");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Unknow
                }
                update_DataGridView_Customer();
            }

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private async void update_DataGridView_Product()
        {
            button_product.BackColor = Color.Orange;
            button_customer.BackColor = Color.White;
            button_Brand.BackColor = Color.White;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            string url = GlobalVariable.url + "api/product/getall";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<PRODUCT>>(json);
            dataGridView1.DataSource = list;
            dataGridView1.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa Product";
            btn_Xoa.UseColumnTextForButtonValue = true;

        }
        private void button_product_Click(object sender, EventArgs e)
        {
            update_DataGridView_Product();
        }

        private async void update_DataGridView_Customer()
        {
            button_product.BackColor = Color.White;
            button_customer.BackColor = Color.Orange;
            button_Brand.BackColor = Color.White;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            string url = GlobalVariable.url + "api/customer/getall";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<CUSTOMER>>(json);
            dataGridView1.DataSource = list;
            dataGridView1.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa Customer";
            btn_Xoa.UseColumnTextForButtonValue = true;

        }
        private void button_customer_Click(object sender, EventArgs e)
        {
            update_DataGridView_Customer();
        }

        private void button_Brand_Click(object sender, EventArgs e)
        {
            update_DataGridView();
        }
    }
}
