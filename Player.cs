using System.ComponentModel;

namespace InterfacePrototype
{

    public enum Directions
    {
        North,
        East,
        South,
        West
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Player : INotifyPropertyChanged
    {


        public Directions CurrentDirection;
        
        
         
        public Player()
        {
            this.CurrentDirection = Directions.South;


        }

        //methods

    }
}
