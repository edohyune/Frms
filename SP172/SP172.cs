using DevExpress.XtraGrid.Views.Grid;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace EpicV004.Frms
{
    public partial class SP172 : FrmBase
    {
        public SP172()
        {
            InitializeComponent();
        }

        private void SP172_Load(object sender, EventArgs e)
        {
            f_word.UCEditValueChanged += f_word_UCEditValueChanged;
        }

        private void ucSplit1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        protected override void BarButtonAction(string frm, string action)
        {


            string searchStr = g20.GetText("Id").ToString();

            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save()) // Perform save operation
                        {
                            g20.Open(); // Reload the grid data
                            g30.Open();
                            g40.Open();

                            // Wait until the data is fully loaded
                            Application.DoEvents();

                            // Try to find and focus on the saved row
                            for (int i = 0; i < g20.RowCount; i++)
                            {
                                if (g20.GetText("Id", i) == searchStr)
                                {
                                    g20.FocusedRowIndex = i; // Move focus to the found row
                                    break;
                                }
                            }
                        }
                        //g40.Open(); // Refresh the Mapping Grid
                        break;

                    case "Open":
                        this.Open();
                        break;

                    case "New":
                        g20.New();
                        break;
                    case "Delete":
                    this.Delete();
                        break;

                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }

            // Get the currently focused row's ID before saving
            //string searchStr = g20.GetText("Id").ToString();

            //if (this.Name == frm)
            //{
            //    switch (action)
            //    {
            //        case "Save":
            //            if (this.Save()) // Perform save operation
            //            {
            //                g20.Open(); // Reload the grid data

            //                // Try to focus on the latest saved row
            //                g20.FocuseByFindedValue("Id", searchStr);
            //            }
            //            g40.Open(); // Refresh the Mapping Grid
            //            break;

            //        case "Open":
            //            this.Open();
            //            break;

            //        case "New":
            //            g20.New();
            //            break;

            //        default:
            //            base.BarButtonAction(frm, action);
            //            break;
            //    }
            //}
        }

        private void ucSplit4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Ensure `g30` (Words Panel) and `g40` (Mapping Panel) are initialized
            if (g30 == null || g40 == null)
            {
                MessageBox.Show("Error: Grids are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row index in Mapping Panel (g40)
            int selectedRowIndex = g40.FocusedRowIndex;
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Please select a row to add.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve all relevant column values from the selected row in `g40`
            string wordId = g40.GetText("Id", selectedRowIndex)?.Trim();
            string wordEn = g40.GetText("En", selectedRowIndex)?.Trim();
            string wordKr = g40.GetText("Kr", selectedRowIndex)?.Trim();
            string wordLa = g40.GetText("La", selectedRowIndex)?.Trim();
            string useYn = g40.GetText("UseYn", selectedRowIndex)?.Trim();

            // Ensure at least one language field is not empty
            if (string.IsNullOrEmpty(wordId) || (string.IsNullOrEmpty(wordEn) && string.IsNullOrEmpty(wordKr) && string.IsNullOrEmpty(wordLa)))
            {
                MessageBox.Show("Invalid row data. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the word already exists in `g30`
            bool exists = false;
            for (int j = 0; j < g30.RowCount; j++)
            {
                string existingWordId = g30.GetText("Id", j)?.Trim();
                if (!string.IsNullOrEmpty(existingWordId) && existingWordId.Equals(wordId))
                {
                    exists = true;
                    break;
                }
            }

            // If word is new, add it to the Words Panel (`g30`)
            if (!exists)
            {
                g30.New(); // Add a new row in Words Panel
                Application.DoEvents(); // Allow UI to process updates

                // Ensure we are setting values on the last row
                int newRowIndex = g30.RowCount - 1;
                g30.FocusedRowIndex = newRowIndex; // Ensure focus is on the newly added row

                // Apply values to the new row
                g30.SetText("Id", newRowIndex, wordId);
                g30.SetText("En", newRowIndex, wordEn);
                g30.SetText("Kr", newRowIndex, wordKr);
                g30.SetText("La", newRowIndex, wordLa);
                g30.SetText("UseYn", newRowIndex, string.IsNullOrEmpty(useYn) ? "1" : useYn); // Default to "1" if empty

                //MessageBox.Show($"Added word: {wordEn ?? wordKr ?? wordLa} (ID: {wordId})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This word already exists in the Words Panel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //// Ensure `g30` (Words Panel) and `g40` (Mapping Panel) are initialized
            //if (g30 == null || g40 == null)
            //{
            //    MessageBox.Show("Error: Grids are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Get the selected row index in Mapping Panel (g40)
            //int selectedRowIndex = g40.FocusedRowIndex;
            //if (selectedRowIndex < 0)
            //{
            //    MessageBox.Show("Please select a row to add.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Retrieve all relevant column values from the selected row in `g40`
            //string wordId = g40.GetText("Id", selectedRowIndex);
            //string wordEn = g40.GetText("En", selectedRowIndex);
            //string wordKr = g40.GetText("Kr", selectedRowIndex);
            //string wordLa = g40.GetText("La", selectedRowIndex);
            //string useYn  = g40.GetText("UseYn", selectedRowIndex);

            //// Ensure at least one language field is not empty
            //if (string.IsNullOrEmpty(wordId) || (string.IsNullOrEmpty(wordEn) && string.IsNullOrEmpty(wordKr) && string.IsNullOrEmpty(wordLa)))
            //{
            //    MessageBox.Show("Invalid row data. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Check if the word already exists in Words Panel (`g30`)
            //bool exists = false;
            //for (int j = 0; j < g30.RowCount; j++)
            //{
            //    if (g30.GetText("Id", j) == wordId)
            //    {
            //        exists = true;
            //        break;
            //    }
            //}

            //// If word is new, add it to the Words Panel (`g30`)
            //if (!exists)
            //{
            //    g30.New(); // Add a new row in Words Panel
            //    int newRowIndex = g30.FocusedRowIndex; // Get the new row index

            //    // Copy all columns to `g30`
            //    g30.SetText("Id", newRowIndex, wordId);
            //    g30.SetText("En", newRowIndex, wordEn);
            //    g30.SetText("Kr", newRowIndex, wordKr);
            //    g30.SetText("La", newRowIndex, wordLa);
            //    g30.SetText("UseYn", newRowIndex, string.IsNullOrEmpty(useYn) ? "1" : useYn); // Default to "1" if empty

            //   // MessageBox.Show($"Added word: {wordEn ?? wordKr ?? wordLa} (ID: {wordId})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("This word already exists in the Words Panel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}



            //// Ensure `g30` (Words Panel) and `g40` (Mapping Panel) are initialized
            //if (g30 == null || g40 == null)
            //{
            //    MessageBox.Show("Error: Grids are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Get the selected row index in Mapping Panel (g40)
            //int selectedRowIndex = g40.FocusedRowIndex;
            //if (selectedRowIndex < 0)
            //{
            //    MessageBox.Show("Please select a row to add.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Retrieve word ID and word text from the selected row in Mapping Grid (g40)
            //string wordId = g40.GetText("Id", selectedRowIndex);
            //string wordText = g40.GetText("words", selectedRowIndex);

            //if (string.IsNullOrEmpty(wordId) || string.IsNullOrEmpty(wordText))
            //{
            //    MessageBox.Show("Invalid row data. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Check if the word already exists in Words Panel (g30)
            //bool exists = false;
            //for (int j = 0; j < g30.RowCount; j++)
            //{
            //    if (g30.GetText("Id", j) == wordId)
            //    {
            //        exists = true;
            //        break;
            //    }
            //}

            //// If word is new, add it to the Words Panel (g30)
            //if (!exists)
            //{
            //    g30.New(); // Add a new row in Words Panel
            //    int newRowIndex = g30.FocusedRowIndex; // Get the new row index

            //    g30.SetText("Id", newRowIndex, wordId);
            //    g30.SetText("En", newRowIndex, wordText);
            //    g30.SetText("Kr", newRowIndex, wordText);
            //    g30.SetText("La", newRowIndex, wordText); // Assuming "Words" is in the English column
            //    g30.SetText("UseYn", newRowIndex, "1"); // Default status

            //    //MessageBox.Show($"Added word: {wordText}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("This word already exists in the Words Panel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


            //// Ensure `g30` (Words) and `g40` (Mapping) are initialized
            //if (g30 == null || g40 == null)
            //{
            //    MessageBox.Show("Error: Grids are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Get the total row count from Mapping Panel (g40)
            //int rowCount = g40.RowCount;
            //if (rowCount == 0)
            //{
            //    MessageBox.Show("No data to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //// Loop through each row in Mapping Panel (g40)
            //for (int i = 0; i < rowCount; i++)
            //{
            //    // Retrieve word ID and word text from Mapping Grid (g40)
            //    string wordId = g40.GetText("Id", i);
            //    string wordText = g40.GetText("words", i);

            //    if (string.IsNullOrEmpty(wordId) || string.IsNullOrEmpty(wordText))
            //        continue; // Skip empty rows

            //    // Check if the word already exists in Words Panel (g30)
            //    bool exists = false;
            //    for (int j = 0; j < g30.RowCount; j++)
            //    {
            //        if (g30.GetText("Id", j) == wordId)
            //        {
            //            exists = true;
            //            break;
            //        }
            //    }

            //    // If word is new, add it to the Words Panel (g30)
            //    if (!exists)
            //    {
            //        g30.New(); // Add a new row in Words Panel
            //        int newRowIndex = g30.FocusedRowIndex; // Get the new row index

            //        g30.SetText("Id", newRowIndex, wordId);
            //        g30.SetText("En", newRowIndex, wordText); // Assuming "Words" is in the English column
            //        g30.SetText("UseYn", newRowIndex, "1"); // Default status
            //    }
            //}

            //MessageBox.Show("Words added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        private void btnNew_Click(object sender, EventArgs e)
        {

            // Ensure `g30` (Words Panel) is initialized
            if (g30 == null)
            {
                MessageBox.Show("Error: Words Panel (g30) is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected language from the ComboBox
            string selectedLanguage = f_lang.Text?.ToString();
            if (string.IsNullOrEmpty(selectedLanguage))
            {
                MessageBox.Show("Please select a language.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine the correct column based on the selected language
            string targetColumn = "";
            switch (selectedLanguage)
            {
                case "English": targetColumn = "En"; break;
                case "Korean": targetColumn = "Kr"; break;
                case "Lao": targetColumn = "La"; break;
                case "Thai": targetColumn = "Th"; break;
                case "Chinese": targetColumn = "Ch"; break;
                case "Vietnamese": targetColumn = "Vn"; break;
                default:
                    MessageBox.Show("Invalid language selection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Get the text from the Words textbox
            string wordText = f_word.Text.Trim();
            if (string.IsNullOrEmpty(wordText))
            {
                MessageBox.Show("Please enter a word.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add a new row in Words Panel (`g30`)
            g30.New();
            Application.DoEvents(); // Allow UI updates

            // Ensure we are setting values on the last row
            int newRowIndex = g30.RowCount - 1;
            g30.FocusedRowIndex = newRowIndex; // Move focus to the new row

            // Insert the word into the correct language column
            //g30.SetText("Id", newRowIndex, (g30.RowCount + 19).ToString()); // Generate a unique ID
            g30.SetText(targetColumn, newRowIndex, wordText);
            g30.SetText("UseYn", newRowIndex, "1"); // Default to active

            //MessageBox.Show($"Added '{wordText}' to column '{targetColumn}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //g30.New();
            
    }

        private void f_lang_UCSelectedIndexChanged(object sender, EventArgs e)
        {
            g40.Open();
        }

        private void f_word_UCEditValueChanged(object Sender, Control control)
        {
            // Ensure `g40` (Mapping Panel) is initialized
            if (g40 == null || g40.MainView == null)
                return;

            // Get the selected language from `f_lang`
            string selectedLanguage = f_lang.Text?.ToString();
            if (string.IsNullOrEmpty(selectedLanguage))
                return;

            // Determine the column to filter based on the selected language
            string filterColumn = "";
            switch (selectedLanguage)
            {
                case "English": filterColumn = "En"; break;
                case "Korean": filterColumn = "Kr"; break;
                case "Lao": filterColumn = "La"; break;
                case "Thai": filterColumn = "Th"; break;
                case "Chinese": filterColumn = "Ch"; break;
                case "Vietnamese": filterColumn = "Vn"; break;
                default:
                    return;
            }

            // Get the input text from `f_word`
            string searchText = f_word.Text.Trim();

            // Get the GridView from `g40` (assuming it's a DevExpress GridControl)
            GridView view = g40.MainView as GridView;
            if (view == null)
                return;

            // Ensure the selected column exists in the grid
            if (view.Columns[filterColumn] == null)
                return;

            // Apply search filter dynamically without showing the popup
            if (string.IsNullOrEmpty(searchText))
            {
                view.ApplyFindFilter(""); // Clear filter if no text
            }
            else
            {
                view.ClearColumnsFilter(); // Remove any previous filters
                view.ApplyFindFilter(searchText); // Apply the search filter
            }
            //-----------------no popup but lao can not search--------------------
            // Ensure `g40` (Mapping Panel) is initialized
            //if (g40 == null || g40.MainView == null)
            //    return;

            //// Get the selected language from `f_lang` (assuming it's a ComboBox or similar control)
            //string selectedLanguage = f_lang.Text?.ToString();
            //if (string.IsNullOrEmpty(selectedLanguage))
            //    return;

            //// Determine the column to filter based on the selected language
            //string filterColumn = "";
            //switch (selectedLanguage)
            //{
            //    case "English": filterColumn = "En"; break;
            //    case "Korean": filterColumn = "Kr"; break;
            //    case "Lao": filterColumn = "La"; break;
            //    case "Thai": filterColumn = "Th"; break;
            //    case "Chinese": filterColumn = "Ch"; break;
            //    case "Vietnamese": filterColumn = "Vn"; break;
            //    default:
            //        return;
            //}

            //// Get the input text from `f_word`
            //string searchText = f_word.Text.Trim();

            //// Get the GridView from `g40` (assuming it's a DevExpress GridControl)
            //GridView view = g40.MainView as GridView;
            //if (view == null)
            //    return;

            //// Apply search filter dynamically without showing the filter popup
            //if (string.IsNullOrEmpty(searchText))
            //{
            //    view.ApplyFindFilter(""); // Clear filter if no text
            //}
            //else
            //{
            //    view.ApplyFindFilter(searchText); // Search across the selected column
            //}

            //--------popup show not perfect---------------------------------------
            //// Ensure `g40` (Mapping Panel) is initialized
            //if (g40 == null || g40.MainView == null)
            //    return;

            //// Get the selected language from `f_lang` (assuming it's a ComboBox or similar control)
            //string selectedLanguage = f_lang.Text?.ToString();
            //if (string.IsNullOrEmpty(selectedLanguage))
            //    return;

            //// Determine the column to filter based on the selected language
            //string filterColumn = "";
            //switch (selectedLanguage)
            //{
            //    case "English": filterColumn = "En"; break;
            //    case "Korean": filterColumn = "Kr"; break;
            //    case "Lao": filterColumn = "La"; break;
            //    case "Thai": filterColumn = "Th"; break;
            //    case "Chinese": filterColumn = "Ch"; break;
            //    case "Vietnamese": filterColumn = "Vn"; break;
            //    default:
            //        return;
            //}

            //// Get the input text from `f_word`
            //string searchText = f_word.Text.Trim();

            //// Get the GridView from `g40` (assuming it's a DevExpress GridControl)
            //GridView view = g40.MainView as GridView;
            //if (view == null)
            //    return;

            //// Apply search filter dynamically
            //if (string.IsNullOrEmpty(searchText))
            //{
            //    view.ActiveFilter.Clear(); // Clear filter if no text
            //}
            //else
            //{
            //    view.ActiveFilterString = $"[{filterColumn}] LIKE '%{searchText}%'";
            //}
        }

        private void SId_UCEditValueChanged(object Sender, Control control)
        {

        }
    }
}
