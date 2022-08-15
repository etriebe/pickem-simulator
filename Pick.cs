using System;
public class Pick
{
    public bool CorrectPick;
    public bool IsKeyPick;

    public Pick(bool isKeyPick)
    {
        Random r = new Random();
        int result = r.Next(2);
        if (result == 0)
        {
            this.CorrectPick = false;
        }
        else if (result == 1)
        {
            this.CorrectPick = true;
        }
        else
        {
            throw new Exception("Fix random ranges");
        }

        this.IsKeyPick = isKeyPick;
    }
}