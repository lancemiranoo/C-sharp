using System.Windows.Forms;

public class Cat: Animal, ISound
{
    public override string Type => "Cat";   // Specific type for Cat
    public void MakeSound()
    {
        MessageBox.Show("Meow! Meow!"); // Cat's unique sound
    }
}