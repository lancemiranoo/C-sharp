namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure fields are filled out
                if (!IsValidData()) return;

                // Define the expected date format
                string dateFormat = "MM/dd/yyyy";

                // Parse arrival and departure dates
                DateTime arrivalDate;
                DateTime departureDate;

                bool isArrivalDateValid = DateTime.TryParseExact(txtArrivalDate.Text, dateFormat, null, System.Globalization.DateTimeStyles.None, out arrivalDate);
                bool isDepartureDateValid = DateTime.TryParseExact(txtDepartureDate.Text, dateFormat, null, System.Globalization.DateTimeStyles.None, out departureDate);

                // Calculate the number of nights
                int numberOfNights = (departureDate - arrivalDate).Days;

                // Initialize total price
                decimal totalPrice = 0m;

                // Calculate the price based on the day of the week using a while loop
                DateTime currentDate = arrivalDate;
                while (currentDate < departureDate)
                {
                    if (currentDate.DayOfWeek == DayOfWeek.Friday || currentDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        totalPrice += 150m; // Charge for Friday and Saturday nights
                    }
                    else
                    {
                        totalPrice += 120m; // Charge for other nights
                    }
                    currentDate = currentDate.AddDays(1); // Move to the next day
                }

                // Calculate average price per night
                decimal averagePrice = totalPrice / numberOfNights;

                // Display results
                txtNights.Text = numberOfNights.ToString();
                txtTotalPrice.Text = totalPrice.ToString("c");    // Display as currency
                txtAvgPrice.Text = averagePrice.ToString("c");     // Display as currency
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid dates in the format MM/dd/yyyy.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Validate presence of Arrival date
            errorMessage += IsPresent(txtArrivalDate.Text, "Arrival date");

            // Validate presence of Departure date
            errorMessage += IsPresent(txtDepartureDate.Text, "Departure date");

            // Validate Arrival date format and range
            errorMessage += IsDateTime(txtArrivalDate.Text, "Arrival date");
            errorMessage += IsWithinDateRange(txtArrivalDate.Text, "Arrival date", DateTime.Today, DateTime.Today.AddYears(5));

            // Validate Departure date format and range
            errorMessage += IsDateTime(txtDepartureDate.Text, "Departure date");
            errorMessage += IsWithinDateRange(txtDepartureDate.Text, "Departure date", DateTime.Today, DateTime.Today.AddYears(5));

            // Validate that Departure date is later than Arrival date
            errorMessage += IsLaterDate(txtArrivalDate.Text, "Arrival date", txtDepartureDate.Text, "Departure date");

            if (!string.IsNullOrEmpty(errorMessage))
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }

            return success;
        }

        public string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }
            return msg;
        }

        public string IsDateTime(string value, string name)
        {
            string msg = "";
            DateTime dateValue;
            // Ensure MM/dd/yyyy format
            if (!DateTime.TryParseExact(value, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateValue))
            {
                msg = $"{name} must be a valid date in the format MM/dd/yyyy.\n";
            }
            return msg;
        }

        public string IsWithinDateRange(string value, string name, DateTime min, DateTime max)
        {
            string msg = "";
            DateTime dateValue;
            // Ensure MM/dd/yyyy format
            if (DateTime.TryParseExact(value, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateValue))
            {
                if (dateValue < min || dateValue > max)
                {
                    msg = $"{name} must be between {min:MM/dd/yyyy} and {max:MM/dd/yyyy}.\n";
                }
            }
            return msg;
        }

        public string IsLaterDate(string earlyValue, string earlyName, string laterValue, string laterName)
        {
            string msg = "";
            DateTime earlyDate, laterDate;
            // Ensure MM/dd/yyyy format
            if (DateTime.TryParseExact(earlyValue, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out earlyDate) &&
                DateTime.TryParseExact(laterValue, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out laterDate))
            {
                if (laterDate <= earlyDate)
                {
                    msg = $"{laterName} must be later than {earlyName}.\n";
                }
            }
            return msg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}