using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheaterTicketingSystem.GlobalSettings;
using DevExpress.CodeParser;
using TheaterTicketingSystem.Models;
using TheaterTicketingSystem.View.Employee.Form;

namespace TheaterTicketingSystem.View.Employee.UserControl
{
    public partial class TicketBookingUC : DevExpress.XtraEditors.XtraUserControl
    {
        private List<Movie> movieList = new List<Movie>();

        private bool bookTicketIsActive = false;
        public TicketBookingUC()
        {
            InitializeComponent();
            LoadHalls();
            LoadMovies();

            simpleButtonBookTicket.Enabled = false;
            simpleButtonBookTicket.Appearance.BackColor = Color.FromArgb(51, 51, 51);
            simpleButtonBookTicket.Appearance.Options.UseBackColor = true;
        }

        private void TicketBookingUC_Load(object sender, EventArgs e)
        {
        }

        

        

        #region Functions
        private void LoadHalls()
        {
            ConnectionString cs = new ConnectionString();
            using (SqlConnection conn = new SqlConnection(cs.connectionString))
            {
                string query = "SELECT HallID, HallName FROM Halls";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    comboBoxEditSelectHall.Properties.Items.Clear();

                    while (reader.Read())
                    {
                        var hall = new Hall
                        {
                            HallID = Convert.ToInt32(reader["HallID"]),
                            HallName = reader["HallName"].ToString()
                        };
                        comboBoxEditSelectHall.Properties.Items.Add(hall);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error loading halls: " + ex.Message);
                }
            }
        }

        private void LoadMovies()
        {
            ConnectionString cs = new ConnectionString();
            using (SqlConnection conn = new SqlConnection(cs.connectionString))
            {
                string query = "SELECT MovieID, Title, Genre FROM Movies WHERE IsActive = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBoxEditSelectMovie.Properties.Items.Clear();
                    movieList.Clear();

                    while (reader.Read())
                    {
                        Movie movie = new Movie
                        {
                            MovieID = (int)reader["MovieID"],
                            Title = reader["Title"].ToString(),
                            Genre = reader["Genre"].ToString()
                        };

                        movieList.Add(movie);
                        comboBoxEditSelectMovie.Properties.Items.Add(movie.Title);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error loading movies: " + ex.Message);
                }
            }
        }

        private void LoadShowtimes(int movieId)
        {
            ConnectionString cs = new ConnectionString();
            using (SqlConnection conn = new SqlConnection(cs.connectionString))
            {
                string query = @"
                    SELECT ShowtimeDate, StartTime
                    FROM Showtimes
                    WHERE MovieID = @MovieID
                    ORDER BY ShowtimeDate, StartTime";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movieId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBoxEditShowTime.Properties.Items.Clear();

                    while (reader.Read())
                    {
                        DateTime date = Convert.ToDateTime(reader["ShowtimeDate"]);
                        TimeSpan time = (TimeSpan)reader["StartTime"];

                        DateTime fullShowtime = date + time;

                        string formatted = fullShowtime.ToString("MMMM d, yyyy - h:mm tt");
                        comboBoxEditShowTime.Properties.Items.Add(formatted);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error loading showtimes: " + ex.Message);
                }
            }
        }

        private void CheckIfReadyToBook()
        {
            // icheck if tanan combox kay na nay gi select
            bool allSelected =
            !string.IsNullOrWhiteSpace(comboBoxEditSelectMovie.Text) &&
            !string.IsNullOrWhiteSpace(comboBoxEditShowTime.Text) &&
            !string.IsNullOrWhiteSpace(comboBoxEditSelectHall.Text);

            simpleButtonBookTicket.Enabled = allSelected;
            simpleButtonBookTicket.Appearance.BackColor = allSelected
                ? Color.FromArgb(0, 191, 99) // green
                : Color.FromArgb(51, 51, 51); // gray

            if (allSelected)
            {
                // If HallAUC is not yet loaded, add it
                bookTicketIsActive = false;
                HallAUC hallUC = panelHall.Controls.OfType<HallAUC>().FirstOrDefault();
                int showtimeId = GetSelectedShowtimeID(); 
                UpdateSeatColors(showtimeId, hallUC);
            }
        }
        private int GetSelectedShowtimeID()
        {
            try
            {
                string movieTitle = comboBoxEditSelectMovie.Text;
                string showtimeText = comboBoxEditShowTime.Text; // e.g., "June 25, 2025 - 5:00 PM"
                string hallName = comboBoxEditSelectHall.Text;

                // 🕓 Try to parse the showtime string into a DateTime object
                // Expected format: "June 27, 2025 - 7:30 PM"
                if (!DateTime.TryParseExact(showtimeText, "MMMM d, yyyy - h:mm tt",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime parsedDateTime))
                {
                    // ❌ If parsing fails, show an error message and return -1
                    XtraMessageBox.Show("Invalid showtime format.");
                    return -1;
                }

                int showtimeId = -1; // Default value if not found

                // 🔌 Create and open the database connection
                ConnectionString cs = new ConnectionString();
                using (SqlConnection conn = new SqlConnection(cs.connectionString))
                {
                    // 📦 SQL query to find the matching ShowtimeID
                    string query = @"
                                    SELECT s.ShowtimeID
                                    FROM Showtimes s
                                    INNER JOIN Movies m ON s.MovieID = m.MovieID
                                    INNER JOIN Halls h ON s.HallID = h.HallID
                                    WHERE m.Title = @Title AND h.HallName = @HallName
                                    AND s.ShowtimeDate = @Date AND s.StartTime = @Time";

                    // 🧷 Prepare the SQL command and add parameters
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", movieTitle);                // movie title from UI
                    cmd.Parameters.AddWithValue("@HallName", hallName);              // hall name from UI
                    cmd.Parameters.AddWithValue("@Date", parsedDateTime.Date);       // just the date part
                    cmd.Parameters.AddWithValue("@Time", parsedDateTime.TimeOfDay);  // just the time part

                    conn.Open(); // 🚪 Open the database connection

                    object result = cmd.ExecuteScalar(); // 🎯 Get a single value (ShowtimeID)

                    // ✅ If a matching ShowtimeID is found, convert it to int
                    if (result != null)
                        showtimeId = Convert.ToInt32(result);
                }

                return showtimeId; // ✅ Return the found ShowtimeID
            }
            catch (Exception ex)
            {
                // ⚠️ Handle any unexpected errors and show the message
                XtraMessageBox.Show("Error getting ShowtimeID: " + ex.Message);
                return -1; // Return error code
            }
        }

        private void UpdateSeatColors(int showtimeId, HallAUC hallUC)
        {
            ConnectionString cs = new ConnectionString();

            using (SqlConnection conn = new SqlConnection(cs.connectionString))
            {
                // kwaon tana seat number ug ang seat status depende sa imong ihatag nga @ShowtimeID
                string query = @"
                                SELECT s.SeatNumber, ss.StatusID
                                FROM Seats s                                                           
                                LEFT JOIN ShowtimeSeats ss ON s.SeatID = ss.SeatID AND ss.ShowtimeID = @ShowtimeID
                                WHERE s.HallID = 1"; // assuming Hall A only 
                                                     // TODO: ilisdi ni ug naa kay bag ong hall kay naka default nig A

                SqlCommand cmd = new SqlCommand(query, conn);

                // ag value sa showtimeId nga naas parameter is ihatag sya sa @ShowtimeID which is parameter sa DB
                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // iloop tanan tamn mabasa tanan data ayha mugawas sa loop
                    while (reader.Read())
                    {
                        // kwaon niya and SeatNumber sa database tas gam on niyag string tas ibutang niya sa seatNumber nga variable
                        string seatNumber = reader["SeatNumber"].ToString();

                        // read the seat status ID (1 = Available, 2 = Reserved, 3 = Sold)
                        // if ang StatusID is dli null kay iconvert niya ang StatusID into int tas ihatag ang value sa statusId tas if false kay mag default value syag 1 which means nga available sya
                        int statusId = reader["StatusID"] != DBNull.Value ? Convert.ToInt32(reader["StatusID"]) : 1;

                        // iconstruct ang button name kay akong format sa mga button nga seat kay buttonSeatA1, buttonSeatB3, etc...
                        var buttonName = "buttonSeat" + seatNumber;

                        // use reflection to find the Button control with the matching name in HallAUC
                        var seatButton = hallUC.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                        // kung ga exist ang button kay i change ang color depends on status if available or not
                        if (seatButton != null)
                        {
                            switch (statusId)
                            {
                                case 1: // available (Green)
                                    seatButton.BackColor = Color.FromArgb(0, 191, 99);
                                    seatButton.Enabled = true;
                                    break;
                                case 2: // reserved (Yellow)
                                    if (bookTicketIsActive)
                                    {
                                        seatButton.Enabled = false;
                                        seatButton.BackColor = Color.FromArgb(37, 37, 37);
                                    }
                                    else
                                    {
                                        seatButton.Enabled = true;
                                        seatButton.BackColor = Color.FromArgb(255, 222, 89);
                                    }
                                    break;
                                case 3: // sold (Red)
                                    if (bookTicketIsActive)
                                    {
                                        seatButton.Enabled = false;
                                        seatButton.BackColor = Color.FromArgb(37, 37, 37);
                                    }
                                    else
                                    {
                                        seatButton.Enabled = true;
                                        seatButton.BackColor = Color.FromArgb(255, 49, 49);
                                    }
                                    break;
                            }
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error updating seat colors: " + ex.Message);
                }
            }
        }

        private void bookTicketFocus()
        {
            simpleButtonBookTicket.Text = "SAVE";
            comboBoxEditSelectHall.Enabled = false;
            comboBoxEditShowTime.Enabled = false;
            comboBoxEditSelectMovie.Enabled = false;
            buttonActivityLog.Enabled = false;
            buttonShowtimeOverview.Enabled = false;
            buttonSignOut.Enabled = false;
            buttonTicketBooking.Enabled = false;
        }

        private void bookTicketFocusCancel()
        {
            simpleButtonBookTicket.Text = "BOOK TICKET";
            comboBoxEditSelectHall.Enabled = true;
            comboBoxEditShowTime.Enabled = true;
            comboBoxEditSelectMovie.Enabled = true;
            buttonActivityLog.Enabled = true;
            buttonShowtimeOverview.Enabled = true;
            buttonSignOut.Enabled = true;
            buttonTicketBooking.Enabled = true;
        }

        #endregion


        #region EventHandlers

        private void comboBoxEditSelectHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelControlSelectHall.Visible = false;
            string selectedHall = comboBoxEditSelectHall.SelectedItem?.ToString();
            panelHall.Controls.Clear();

            if (selectedHall == "Hall A")
            {
                HallAUC hallAUC = new HallAUC();
                hallAUC.Dock = DockStyle.Fill;
                panelHall.Controls.Add(hallAUC);
            }

            CheckIfReadyToBook();
            // Optional: Handle other halls if needed
            // else if (selectedHall == "Hall B") { ... }
        }


        private void comboBoxEditSelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelControlSelectMovie.Visible = false;
            string selectedTitle = comboBoxEditSelectMovie.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(selectedTitle))
            {
                // Find selected movie
                Movie selectedMovie = movieList.FirstOrDefault(m => m.Title == selectedTitle);

                if (selectedMovie != null)
                {
                    labelControlMovieTitle.Text = selectedMovie.Title;
                    labelControlMovieGenre.Text = selectedMovie.Genre;
                    LoadShowtimes(selectedMovie.MovieID);
                }
            }

            CheckIfReadyToBook();
        }

        private void comboBoxEditShowTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelControlShowTime.Visible = false;
            CheckIfReadyToBook();
        }
        
        // TODO: STUDY 1
        private void simpleButtonBookTicket_Click(object sender, EventArgs e)
        {


            // Activate ticket booking mode
            bookTicketIsActive = true;
            simpleButtonCancel.Enabled = true;
            simpleButtonCancel.Appearance.BackColor = Color.FromArgb(255, 49, 49); // Red

            HallAUC hallUC = panelHall.Controls.OfType<HallAUC>().FirstOrDefault();
            int showtimeId = GetSelectedShowtimeID();
            UpdateSeatColors(showtimeId, hallUC);

            bookTicketFocus();

        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            bookTicketIsActive = false;
            CheckIfReadyToBook();

            bookTicketFocusCancel();

            // ma disable sya ig imong icancel
            simpleButtonCancel.Enabled=false;
        }

        #endregion



    }
}
