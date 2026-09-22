public class ScriptureGenerator
{
    private List<Scripture> _scripture = new List<Scripture>();

    public Scripture GetRandomScripture()
    {
        // 1. Add the first scripture
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        string scripture1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        _scripture.Add(new Scripture(reference1, scripture1));

        // 2. Add another scripture
        Reference reference2 = new Reference("Joshua", 24, 15);
        string scripture2 = "And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.";
        _scripture.Add(new Scripture(reference2, scripture2));

        // 3. Add another scripture
        Reference reference3 = new Reference("1 Samuel", 16, 7);
        string scripture3 = "But the Lord said unto Samuel, Look not on his countenance, or on the height of his stature; because I have refused him: for the Lord seeth not as man seeth; for man looketh on the outward appearance, but the Lord looketh on the heart.";
        _scripture.Add(new Scripture(reference3, scripture3));
        
        // 4. Add another scripture
        Reference reference4 = new Reference("Isaiah", 9, 6);
        string scripture4 = "For unto us a child is born, unto us a son is given: and the government shall be upon his shoulder: and his name shall be called Wonderful, Counsellor, The mighty God, The everlasting Father, The Prince of Peace.";
        _scripture.Add(new Scripture(reference4, scripture4));
        
        Random random = new Random();
        int index = random.Next(_scripture.Count);
        return _scripture[index];
    }
}