using System;
using System.Collections.Generic;
using System.Text;
using ECS_;

namespace ECS_
{
    public class FakeHeater : IFakeHeater
    {


        bool IFakeHeater.FakeTurnOn(int i)
        {
            if (i == 1)
            {
                return true;
            }
            else if (i == 2)
            {
                return false;
            }

            return false;

        }
    }
}