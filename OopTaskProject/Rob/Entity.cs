using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public class Entity
    {
        public Vector3F Position { get; set; }
        
        public Entity()
        {
            Position = new Vector3F(0, 0, 0);
        }

    }
}