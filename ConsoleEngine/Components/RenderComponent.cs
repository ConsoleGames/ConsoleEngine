using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine.Components
{
    public class RenderComponent : Component
    {
        public Func<string> GetRepresentation { get; set; }

        private Entity target;

        public RenderComponent(Func<string> getRepresentation)
        {
            GetRepresentation = getRepresentation;
        }

        public override void Setup(Entity entity)
        {
            target = entity;
        }

        public override void Update()
        {
            if (!target.HasComponent<MovementComponent>())
                return;

            var movement = target.GetComponent<MovementComponent>();
            Console.SetCursorPosition(movement.Position.X, movement.Position.Y);
            Console.Write(GetRepresentation());
        }
    }
}