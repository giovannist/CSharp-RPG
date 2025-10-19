namespace HelloWorld
{
    public class BaseUI
    {

    }

    public class LocationUI : BaseUI
    {

        Location[] locations;

        public LocationUI(Location[] locations) : base()
        {
            this.locations = locations;
        }

        public string GetUI()
        {
            string uiTop = "-----------------\n|               |";
            string uiBottom = "-----------------";
          //string uiBottom = "|           |";


            foreach (Location location in locations)
            {
                int spacingAmount = location.Name.Length;
                string nameSpacing = "             ";

                for (int i = 0; i < spacingAmount; i++)
                {
                    nameSpacing = nameSpacing.Remove(nameSpacing.Length - 1);
                }
                

                uiTop += $"\n| >{location.Name}{nameSpacing}| \n|               |";
            }

            return $"{uiTop}\n${uiBottom}";
        }
    }   
}