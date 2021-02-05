using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class GameManager: EntityManagerBase<Game> ,IGameService
    {
    }
}
