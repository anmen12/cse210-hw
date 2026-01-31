using System.Runtime.CompilerServices;

class ScriptureGenerator
{
    private List<Scripture> _scriptures = [new Scripture(new Reference("Matthew", 2, 1, 2), "Now when Jesus was born in Bethlehem of Judæa in the days of Herod the king, behold, there came wise men from the east to Jerusalem, Saying, Where is he that is born King of the Jews? for we have seen his star in the east, and are come to worship him."),
                                           new Scripture(new Reference("John", 21, 14), "This is now the third time that Jesus shewed himself to his disciples, after that he was risen from the dead."),
                                           new Scripture(new Reference("1 Kings", 3, 11, 12), "And God said unto him, Because thou hast asked this thing, and hast not asked for thyself long life; neither hast asked riches for thyself, nor hast asked the life of thine enemies; but hast asked for thyself understanding to discern judgment; Behold, I have done according to thy words: lo, I have given thee a wise and an understanding heart; so that there was none like thee before thee, neither after thee shall any arise like unto thee."),
                                           new Scripture(new Reference("D&C", 101, 4-5), "Therefore, they must needs be chastened and tried, even as Abraham, who was commanded to offer up his only son. For all those who will not endure chastening, but deny me, cannot be sanctified.")];    
    public Scripture GenerateScripture()
    {
        Random randomGenerator = new Random();
        return _scriptures[randomGenerator.Next(0, _scriptures.Count)];
    }
}