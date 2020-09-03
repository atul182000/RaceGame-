namespace RaceGame
{
    public static class Factory
    {

        public static int PunterCount { get; set; } = 0;


        public static Punter GetPunter(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Joe();
                case 1:
                    return new Bob();
                case 2:
                    return new Al();
                    //default:
                    //    throw new ArgumentOutOfRangeException(nameof(Id), Id, null);
            }
            return new Joe();
        }

        public static Animal GetAnimal(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Browny();
                case 1:
                    return new Blacky();
                case 2:
                    return new Wolfy();
                case 3:
                    return new S();
                case 4:
                    return new Foxy();
                case 5:
                    return new Pinky();


                    //default:
                    //    throw new ArgumentOutOfRangeException(nameof(Id), Id, null);
            }
            return new Browny();
        }
    }
}
