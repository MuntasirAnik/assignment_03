using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        int customer_counter = 0;
        int index = 0; int index1 = 0; int index2 = 0; int index3 = 0; int index4 = 0;int index5 = 0;


        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string contact = contactTextBox.Text;
            string address = addressTextBox.Text;
            string order = itemComboBox.Text;
            string[] nameArray = new string[10];
            string[] ContactArray = new string[10];
            string[] addressArray = new string[10];
            string[] orderArray = new string[10];
            string[] quantityArray = new string[10];
            string[] priceArray = new string[10];
            if (nameTextBox.Text == "" || contactTextBox.Text == "" || addressTextBox.Text == "")
            {
                MessageBox.Show("Please Enter your info !!! ");
            }
            else
            {
                if(itemComboBox.Text == "Select Item")
                {
                    MessageBox.Show("select an item");
                }
                else
                {
                    if(quantityTextBox.Text=="")
                    {
                        MessageBox.Show("Enter quantity...");
                    }
                    else
                    {
                        customer_counter++;
                        string customer = "";
                        string customer_contact = "";
                        string customer_address= "";
                        string customer_order = "";
                        string order_quantity = "";
                        string total_price = "";
                        // MessageBox.Show(customer_counter.ToString());
                        int quantity = Convert.ToInt32(quantityTextBox.Text);
                        nameArray[index] = nameTextBox.Text;
                        index++;
                        ContactArray[index1] = contactTextBox.Text;
                        index1++;
                        addressArray[index2] = addressTextBox.Text;
                        index2++;
                        orderArray[index3] = itemComboBox.Text;
                        index3++;
                        quantityArray[index4] = quantityTextBox.Text;
                        index4++;                        
                        string price;
                        if (itemComboBox.Text == "Black-120")
                        {
                            price = (120 * quantity).ToString();
                            priceArray[index5] = price;
                            index5++;
                            for (int i = 0; i < 10; i++)
                            {
                                customer += nameArray[i];
                                customer_contact += ContactArray[i];
                                customer_address += addressArray[i];
                                customer_order += orderArray[i];
                                order_quantity += quantityArray[i];
                                total_price += priceArray[i];
                            }
                            customerInfoRichTextBox.Text += "Customer Id :\t" + customer_counter + "\nName:\t\t" + customer + "\nContact no:\t" + customer_contact +
                            "\nAddress:\t\t" + customer_address + "\nOrder:\t\t" + customer_order + "\nQuatity:\t\t" + order_quantity + "\nPrice:\t\t" + total_price + "\n---------------------------------------------------\n";
                            nameTextBox.Text = "";
                            contactTextBox.Text = "";
                            addressTextBox.Text = "";
                            itemComboBox.Text = "Select Item";
                            quantityTextBox.Text = "";

                        }
                        else if (itemComboBox.Text == "Cold-100")
                        {
                            price = (100 * quantity).ToString();
                            priceArray[index5] = price;
                            index5++;
                            for (int i = 0; i < 10; i++)
                            {
                                customer += nameArray[i];
                                customer_contact += ContactArray[i];
                                customer_address += addressArray[i];
                                customer_order += orderArray[i];
                                order_quantity += quantityArray[i];
                                total_price += priceArray[i];
                            }
                            customerInfoRichTextBox.Text += "Customer Id :\t" + customer_counter + "\nName:\t\t" + customer + "\nContact no:\t" + customer_contact +
                            "\nAddress:\t\t" + customer_address + "\nOrder:\t\t" + customer_order + "\nQuatity:\t\t" + order_quantity + "\nPrice:\t\t" + total_price + "\n---------------------------------------------------\n";
                            nameTextBox.Text = "";
                            contactTextBox.Text = "";
                            addressTextBox.Text = "";
                            itemComboBox.Text = "Select Item";
                            quantityTextBox.Text = "";
                        }
                        else if (itemComboBox.Text == "Hot-90")
                        {
                            price = (90 * quantity).ToString();
                            priceArray[index5] = price;
                            index5++;
                            for (int i = 0; i < 10; i++)
                            {
                                customer += nameArray[i];
                                customer_contact += ContactArray[i];
                                customer_address += addressArray[i];
                                customer_order += orderArray[i];
                                order_quantity += quantityArray[i];
                                total_price += priceArray[i];
                            }
                            customerInfoRichTextBox.Text += "Customer Id :\t" + customer_counter + "\nName:\t\t" + customer + "\nContact no:\t" + customer_contact +
                            "\nAddress:\t\t" + customer_address + "\nOrder:\t\t" + customer_order + "\nQuatity:\t\t" + order_quantity + "\nPrice:\t\t" + total_price + "\n---------------------------------------------------\n";
                            nameTextBox.Text = "";
                            contactTextBox.Text = "";
                            addressTextBox.Text = "";
                            itemComboBox.Text = "Select Item";
                            quantityTextBox.Text = "";
                        }
                        else if (itemComboBox.Text == "Regular-60")
                        {
                            price = (60 * quantity).ToString();
                            priceArray[index5] = price;
                            index5++;
                            for (int i = 0; i < 10; i++)
                            {
                                customer += nameArray[i];
                                customer_contact += ContactArray[i];
                                customer_address += addressArray[i];
                                customer_order += orderArray[i];
                                order_quantity += quantityArray[i];
                                total_price += priceArray[i];
                            }
                            customerInfoRichTextBox.Text += "Customer Id :\t" + customer_counter + "\nName:\t\t" + customer + "\nContact no:\t" + customer_contact +
                            "\nAddress:\t\t" + customer_address + "\nOrder:\t\t" + customer_order + "\nQuatity:\t\t" + order_quantity + "\nPrice:\t\t" + total_price + "\n---------------------------------------------------\n";
                            nameTextBox.Text = "";
                            contactTextBox.Text = "";
                            addressTextBox.Text = "";
                            itemComboBox.Text = "Select Item";
                            quantityTextBox.Text = "";
                        }
                       
                    }
                    


                }
            }
        }
      
    }
}
