namespace Engine
{

    public class PlayerQuest
    {


        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }

        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }
    }
}
