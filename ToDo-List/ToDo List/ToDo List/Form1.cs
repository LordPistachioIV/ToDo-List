using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDo_List
{
    public partial class Form1 : Form
    {
        int counter = 0;
        internal static string amendedLine;
        //Used as a global counter that will be used by multiple functions within the program
        string filterActive = "N";
        //Used as a global check for the 'Show Active' filter.
        public string editLine = "";

        /*
         * The program uses a total of 4 text files which are all found in the debug folder
         * They are:
         * ItemList - used to contain all of the items that the user has entered. This is
         *            also used when using the 'Show All' filter.
         * 
         * ActiveItemList - used to contain the active items only, when an item is created
         *                  by the user it will be automatically set to active, will be 
         *                  removed when the item is ran through the complete process.
         *                  This is also used when using the 'Show Active' filter.
         *                  
         * CompletedItemList - used to contain the completed items only, items will only be
         *                     sent to this file when they are put through the 'complete'
         *                     process. This is also used when using the 'Show Completed'
         *                     filter.
         *                     
         * OrganisedItemList - used for display purposes only, this makes sure that when
         *                     ever an item is added, removed or set to complete the list
         *                     is always in alphabetical order. Only for all items.
         *                     
         * OrganisedCompletedItemList - used for display purposes only, this makes sure that
         *                              when displaying completed items they are in 
         *                              alphabetical order.
         *                              
         * OrganisedActiveItemList - used for pisplay purpose only, this makes sure that when
         *                           displaying active items they are in alphabetical order.
         *                     
         * The filers use the relevant files as stated in the file explaination.
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string line;
            filterActive = "N";

            Alphabetical("ItemList.txt", "OrganisedItemList.txt");

            StreamReader file = new StreamReader(@"OrganisedItemList.txt");
            while((line = file.ReadLine()) != null)
            {
                todoItemListChkBx.Items.Add(line);
                counter++;
            }
            file.Close();
            itemTotalLbl.Text = "Total items: " + counter;
            /*
             * Reads each line of the OrganisedItemList.txt file and then addes it to the list box
             * Once it gets to null it stops
             * Counter will be used for total amount of items.
             */
        }

        private void exitProgBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Exit the program completely
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string addedItem, line;

            addedItem = addItemTxtb.Text;

            if((addedItem == "") || (addedItem == " "))
            {
                MessageBox.Show("The entry is not valid, please try again.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.AppendAllText("ItemList.txt", addedItem + Environment.NewLine);
                File.AppendAllText("ActiveItemList.txt", addedItem + Environment.NewLine);
                /*
                 * Takes what has been entered into the text box and addes it to the ItemList.txt file
                 * File can be found in the debug folder
                 * When the item is added it creates a new line so each item is its own line
                 * This is done on both text files as 'ItemList' is used for showing all
                 * 'ActiveItemList' is used for the filter when showing only the active items.
                 */

                Alphabetical("ItemList.txt", "OrganisedItemList.txt");

                todoItemListChkBx.Items.Clear();
                /*
                 * Clearing the items within the list and then going through the listing process
                 * This is here to make sure that the contents are always in alphabetical order
                 */

                StreamReader file = new StreamReader(@"OrganisedItemList.txt");
                while ((line = file.ReadLine()) != null)
                {
                    todoItemListChkBx.Items.Add(line);
                }
                file.Close();

                counter++;
                itemTotalLbl.Text = "Total items: " + counter;
            }
            addItemTxtb.Text = "";
        }

        public static void Alphabetical(string inFiles, string outFiles)
        {
            string In, Out = "OrganisedItemList.txt";
            In = inFiles;
            Out = outFiles;
            var contents = File.ReadAllLines(In);
            Array.Sort(contents);
            File.WriteAllLines(Out, contents);
            /*
             * This takes the contents of the ItemList.txt file and then organises it in alphabetical order
             * Dumps the organised data into OrganisedItemList.txt which is used for display
             */
        }

        private void addItemTxtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addItemBtn_Click(this, new EventArgs());
            }
                /*
                 * Allowing the user to press 'Enter' to add a new item
                 */
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            string itemLine= "", line = null;
            int totalItems = 0;

            totalItems = todoItemListChkBx.Items.Count;

            for(int i = 0; i < totalItems; i++)
            {
                if (todoItemListChkBx.GetItemChecked(i))
                {
                    itemLine = (string)todoItemListChkBx.Items[i];

                    itemTotalLbl.Text = "Total items: " + counter;

                    Alphabetical("ItemList.txt", "OrganisedItemList.txt");
                    Alphabetical("ActiveItemList.txt", "OrganisedActiveItemList.txt");
                    Alphabetical("CompletedItemList.txt", "OrganisedCompletedItemList.txt");
                    //Organising all the documents into alphabetical order

                    using(StreamReader reader = new StreamReader(@"OrganisedActiveItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"ActiveItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, itemLine) == 0)
                                {
                                    counter--;
                                    i--;
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();
                        }
                    }
                    //Removing the item from the active list

                    using (StreamReader reader = new StreamReader(@"OrganisedItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"ItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, itemLine) == 0)
                                {
                                    counter--;
                                    i--;
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();
                        }
                    }
                    //Removing the item from the item list

                    using (StreamReader reader = new StreamReader(@"OrganisedCompletedItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"CompletedItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, itemLine) == 0)
                                {
                                    counter--;
                                    //i--;
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();
                        }
                    }
                    //Removing the item from the completed list
                }
            }
            foreach (var item in todoItemListChkBx.CheckedItems.OfType<string>().ToList())
            {
                todoItemListChkBx.Items.Remove(item);
            }
            //Removing the item from the CheckBox
        }

        private void counterTimer_Tick(object sender, EventArgs e)
        {
            int itemCounter=0;

            StreamReader file = new StreamReader(@"OrganisedItemList.txt");
            while (!file.EndOfStream)
            {
                itemCounter++;
            }

            counter = itemCounter;

            itemTotalLbl.Text = "Total items: " + counter;
            file.Close();
        }

        private void selectAllChkB_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllChkB.Checked == true)
            {
                for (int i = 0; i < todoItemListChkBx.Items.Count; i++)
                {
                    todoItemListChkBx.SetItemChecked(i, true);
                }
            }
            //Setting all items in the CheckBox to checked
            else if (selectAllChkB.Checked == false)
            {
                for (int i = 0; i < todoItemListChkBx.Items.Count; i++)
                {
                    todoItemListChkBx.SetItemChecked(i, false);
                }
            }
            //Setting all items in the CheckBox to unchecked
        }

        private void setCompletedBtn_Click(object sender, EventArgs e)
        {
            string line = "", itemLine = null;
            int totalItems = 0;
            //itemLine = todoItemListChkBx.SelectedItems.ToString();

            totalItems = todoItemListChkBx.Items.Count;

            for (int i = 0; i < totalItems; i++)
            {
                if (todoItemListChkBx.GetItemChecked(i))
                {
                    itemLine = (string)todoItemListChkBx.Items[i];

                    File.AppendAllText("CompletedItemList.txt", itemLine + Environment.NewLine);
                    /*
                     * Sending the selected completed items to the completed text file
                     */

                    using (StreamReader reader = new StreamReader(@"OrganisedActiveItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"ActiveItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, itemLine) == 0)
                                {
                                    counter--;
                                    //i--;
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();

                        }
                    }

                    Alphabetical("ActiveItemList.txt", "OrganisedItemList.txt");

                    itemTotalLbl.Text = "Total items: " + counter;

                    //todoItemListChkBx.Items.Remove(todoItemListChkBx.SelectedItem);
                }
                /*
                 * Taking the selected items out of the active items list as they are completed
                 */
            }
            
            if(filterActive == "Y")
            {
                foreach (var item in todoItemListChkBx.CheckedItems.OfType<string>().ToList())
                {
                    todoItemListChkBx.Items.Remove(item);
                }
            }

            todoItemListChkBx.SelectedIndex = -1;
        }

        private void filterActiveBtn_Click(object sender, EventArgs e)
        {
            string line;
            counter = 0;
            Alphabetical("ActiveItemList.txt", "OrganisedActiveItemList.txt");

            todoItemListChkBx.Items.Clear();

            StreamReader file = new StreamReader(@"OrganisedActiveItemList.txt");
            while ((line = file.ReadLine()) != null)
            {
                todoItemListChkBx.Items.Add(line);
                counter++;
            }
            file.Close();
            filterActive = "Y";
            filterDisplayLbl.Text = "Showing Active";
            itemTotalLbl.Text = "Total items: " + counter;
            
            /*
             * Alphabetising the active item list, clearing the checkbox
             * Adding each item to a line in the checkbox and increasing the counter for each item
             * Displaying to user that 'Showing active' is in use and changing the total label
             */
        }

        private void filterCompletedBtn_Click(object sender, EventArgs e)
        {
            string line;
            counter = 0;

            Alphabetical("CompletedItemList.txt", "OrganisedCompletedItemList.txt");

            todoItemListChkBx.Items.Clear();

            StreamReader file = new StreamReader(@"OrganisedCompletedItemList.txt");
            while ((line = file.ReadLine()) != null)
            {
                todoItemListChkBx.Items.Add(line);
                counter++;
            }
            file.Close();
            filterActive = "N";
            filterDisplayLbl.Text = "Showing Completed";
            itemTotalLbl.Text = "Total items: " + counter;
            
            /*
             * Alphabetising the completed item list, clearing the checkbox
             * Adding each item to a line in the checkbox and increasing the counter for each item
             * Displaying to user that 'Showing completed' is in use and changing the total label
             */
         }

        private void filterAllBtn_Click(object sender, EventArgs e)
        {
            string line;
            counter = 0;

            Alphabetical("ItemList.txt", "OrganisedItemList.txt");

            todoItemListChkBx.Items.Clear();

            StreamReader file = new StreamReader(@"OrganisedItemList.txt");
            while ((line = file.ReadLine()) != null)
            {
                todoItemListChkBx.Items.Add(line);
                counter++;
            }
            file.Close();
            filterActive = "N";
            filterDisplayLbl.Text = "Showing All";
            itemTotalLbl.Text = "Total items: " + counter;
            /*
             * Alphabetising the all item list, clearing the checkbox
             * Adding each item to a line in the checkbox and increasing the counter for each item
             * Displaying to user that 'Showing all' is in use and changing the total label
             */
        }

        private void todoItemListChkBx_KeyDown(object sender, KeyEventArgs e)
        {
            //Not in use
        }

        private void todoItemListChkBx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //User must fill the check box on the item they wish to edit and then double click
            string line = null;
            for (int i = 0; i < todoItemListChkBx.Items.Count; i++)
            {
                if (todoItemListChkBx.GetItemChecked(i))
                {
                    editLine = (string)todoItemListChkBx.Items[i];

                    Edit frm = new Edit();
                    frm.originalLine = editLine;
                    frm.ShowDialog();
                    //Open Edit form, show the edited item so user can edit as they wish

                    amendedLine = frm.TextBoxText;
                    //pull the change from the Edit form.

                    todoItemListChkBx.Items[i] = amendedLine;

                    Alphabetical("ItemList.txt", "OrganisedItemList.txt");
                    Alphabetical("ActiveItemList.txt", "OrganisedActiveItemList.txt");
                    Alphabetical("CompletedItemList.txt", "OrganisedCompletedItemList.txt");
                    //Organising all files

                    using (StreamReader reader = new StreamReader(@"OrganisedActiveItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"ActiveItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, editLine) == 0)
                                //if current line(line) and edited line(editLine) are the same then 
                                {
                                    writer.WriteLine(amendedLine);
                                    //edit line to be 'amendedLine'
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();
                        }
                        
                    }

                    using (StreamReader reader = new StreamReader(@"OrganisedItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"ItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, editLine) == 0)
                                //if current line(line) and edited line(editLine) are the same then
                                {
                                    writer.WriteLine(amendedLine);
                                    //edit line to be 'amendedLine'
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();
                        }
                    }

                    using (StreamReader reader = new StreamReader(@"OrganisedCompletedItemList.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(@"CompletedItemList.txt"))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (String.Compare(line, editLine) == 0)
                                //if current line(line) and edited line(editLine) are the same then
                                {
                                    writer.WriteLine(amendedLine);
                                    //edit line to be 'amendedLine'
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            reader.Close();
                            writer.Close();
                        }
                    }
                    //All three are editing the .txt lists so the change appears on all lists.
                }
            }
        }
    }
}
