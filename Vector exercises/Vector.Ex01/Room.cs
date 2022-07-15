 namespace EV_EX01 {
    internal class Room {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }

        /* public Room(string name, string email, int number) {
             Name = name;
             Email = email;
             Number = number;
         }*/
        override public string ToString() {
            return Name+", " + Email;
        }
    }


}
