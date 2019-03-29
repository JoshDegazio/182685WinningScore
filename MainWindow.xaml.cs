/* Josh Degazio
 * March 28th, 2019
 * Program that calculates apple and banana score, then compares them.
 */
using System.Windows;

namespace _182685WinningScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //strings
        string input;

        //arrays
        string[] inputStrings;
        int[] inputValues = new int[6];

        //apple ints
        int aThreePoint;
        int aTwoPoint;
        int aOnePoint;
        int aTotalPoints;

        //banana ints
        int bThreePoint;
        int bTwoPoint;
        int bOnePoint;
        int bTotalPoints;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index;
            //receieve data from input box
            input = inpt_Box.Text;
            //sort data
            inputStrings = input.Split('\n');
            //parse the array
            for (int x = 0; x < inputStrings.Length - 1; x++)
            {
                if (inputStrings[x].Contains("\r"))
                {
                    index = inputStrings[x].IndexOf("\r");
                    inputStrings[x] = inputStrings[x].Remove(index, 1);
                }
                int.TryParse(inputStrings[x], out inputValues[x]);
            }

            //set apple values
            aThreePoint = inputValues[0];
            aTwoPoint = inputValues[1];
            aOnePoint = inputValues[2];
            //set apple score
            aTotalPoints = (aThreePoint * 3) + (aTwoPoint * 2) + (aOnePoint * 1);

            //set banana values
            bThreePoint = inputValues[3];
            bTwoPoint = inputValues[4];
            bOnePoint = inputValues[5];
            //set banana score
            bTotalPoints = (bThreePoint * 3) + (bTwoPoint * 2) + (bOnePoint * 1);

            //check scores
            if (aTotalPoints > bTotalPoints)
            {
                //apples won!
                outpt_Block.Text = "A";
            }
            else if (aTotalPoints < bTotalPoints)
            {
                //bananas won!
                outpt_Block.Text = "B";
            }
            else if (aTotalPoints == bTotalPoints)
            {
                //aw man! a tie?
                outpt_Block.Text = "T";
            }
            else
            {
                //whoops
                outpt_Block.Text = "Something broke lmao.";
            }
        }
    }
}
