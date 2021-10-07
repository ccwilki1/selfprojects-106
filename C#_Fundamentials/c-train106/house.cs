namespace HouseFunction
{
    public class House
    {
        /*Private will make this C# code only belong to 
        this field*/
        public string owner;
        private string ghost;
        private int roomCount;

        public House()
        {
            owner = "stephen";
            ghost = "Casper";
            roomCount = 1;
        }

        public string Owner { get{ return owner;} set{owner = value + Owner;} }
        public string MiceName { get; set; }
    }
}