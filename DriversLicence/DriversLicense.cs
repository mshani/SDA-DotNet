using System.Runtime.CompilerServices;

namespace DriverLicence
{
    internal class DriversLicense
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Sirname { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? BlockDate { get; set; }
        public DateTime? UnblockDate { get; set; }
        public string? Country { get; set; }
        public string? Type { get; set; }
        public int Points { get; set; }
        public bool IsActive { get {            
                var isActive = false;
                if ((UnblockDate == null || UnblockDate <= DateTime.Now) && Points > 0)
                {
                    isActive = true;
                }
                return isActive;
            } 
        }
        public bool IsValid
        {
            get
            {
                var isValid = false;
                if (ExpirationDate >= DateTime.Now && Points > 0)
                {
                    isValid = true;
                }
                return isValid;
            }
        }
        public List<LicensePenalty> Penalties { get; set; } = new List<LicensePenalty>();

        public DriversLicense(
            string id, 
            string name, 
            string sirname, 
            DateTime birthday,
            DateTime releaseDate,
            DateTime expirationDate,
            string type
            )
        {
            this.Id = id;
            this.Name = name;
            this.Sirname = sirname;
            this.Birthday = birthday;
            this.ReleaseDate = releaseDate;
            this.ExpirationDate = expirationDate;
            this.Country = "AL";
            this.Points = 20;
            this.Type = type;
        }

        public void RemovePoints(int points)
        {
            if (points < 0) {
                Console.WriteLine($"Invalid points argument: {points}");
                return;
            }
            if (!IsValid)
            {
                Console.WriteLine($"Invalid drivers license");
                return;
            }
            if (this.Points - points < 0)
            {
                this.Points = 0;
            }
            else
            {
                this.Points -= points;
            }
            //this.Points = (this.Points - points < 0) ? 0 : this.Points -= points;\
            Console.WriteLine($"Removed points: {points}, Balance: {Points}");
        }
        public void AddPoints(int points)
        {
            if (points < 0)
            {
                Console.WriteLine($"Invalid points argument: {points}");
                return;
            }
            if (!IsValid)
            {
                Console.WriteLine($"Invalid drivers license");
                return;
            }
            if (this.Points + points > 20)
            {
                this.Points = 20;
            }
            else
            {
                this.Points += points;
            }
            //this.Points = (this.Points + points > 20) ? 0 : this.Points += points;
            Console.WriteLine($"Added points: {points}, Balance: {Points}");
        }
        public void BlockLicense(DateTime blockDate, DateTime unBlockDate)
        {
            if (blockDate >= unBlockDate)
            {
                Console.WriteLine("Invalid dates");
                return;
            }
            this.BlockDate = blockDate;
            this.UnblockDate = unBlockDate;
        }
        public void AddPenalty(Penalty penalty, DateTime penaltyDate, string notes)
        {
            var licensePenalty = new LicensePenalty()
            { 
                PenaltyDate = penaltyDate,
                Notes = notes,
                Code = penalty.Code,
                Description = penalty.Description,
                BlockDays = penalty.BlockDays,
                PointsReduction = penalty.PointsReduction,
            };
            Penalties.Add(licensePenalty);
            RemovePoints(penalty.PointsReduction);
            if (penalty.BlockDays > 0)
            {
                BlockLicense(penaltyDate, penaltyDate.AddDays(penalty.BlockDays));
            }
        }
    }
}
