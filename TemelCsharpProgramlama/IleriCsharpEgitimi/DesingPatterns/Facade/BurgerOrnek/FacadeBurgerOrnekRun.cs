using System;


namespace FacadeDesignPatternNamespace
{
    class FacadeDesignPatternOrnekClass
    {
        public static void FacadeDesignPatternOrnekRunMethod()
        {
            BurgerFacade burgerFacade = new BurgerFacade();
            burgerFacade.CheaderBurger();

            burgerFacade.MozzerellaBurger();

            burgerFacade.VeggiesBurger();
        }
    }



    /*
    BURGER ORNEK UML DİAGRAM
    
    +---------------------------------+
    |          <<interface>>          |
    |            IBun                 |
    +---------------------------------+
    | +Toast()                        |
    +---------------------------------+

    +---------------------------------+
    |          <<interface>>          |
    |            IPatty               |
    +---------------------------------+
    | +Grill()                        |
    +---------------------------------+

    +---------------------------------+
    |          <<interface>>          |
    |           IVeggies              |
    +---------------------------------+
    | +AddVegies()                    |
    +---------------------------------+

    +---------------------------------+
    |          <<interface>>          |
    |            ISauce               |
    +---------------------------------+
    | +ApplySauce()                   |
    +---------------------------------+

    +---------------------------------+
    |          <<interface>>          |
    |           ICheese               |
    +---------------------------------+
    | +Mozzerella()                   |
    | +Cheader()                      |
    +---------------------------------+

    +----------------------+
    |        Bun           |
    +----------------------+
    | +Toast()             |
    +----------------------+

    +----------------------+
    |       Patty          |
    +----------------------+
    | +Grill()             |
    +----------------------+

    +----------------------+
    |      Veggies         |
    +----------------------+
    | +AddVegies()         |
    +----------------------+

    +----------------------+
    |       Sauce          |
    +----------------------+
    | +ApplySauce()        |
    +----------------------+

    +----------------------+
    |       Cheese         |
    +----------------------+
    | +Mozzerella()        |
    | +Cheader()           |
    +----------------------+

    +--------------------------------+
    | CrossCuttingConcernsBurger     |
    +--------------------------------+
    | -_bun : IBun                   |
    | -_patty : IPatty               |
    | -_veggies : IVeggies           |
    | -_sauce : ISauce               |
    | -_cheese : ICheese             |
    +--------------------------------+

    +--------------------------------+
    |       BurgerFacade             |
    +--------------------------------+
    | -_corners : CrossCuttingConcernsBurger |
    +--------------------------------+
    | +CheaderBurger()               |
    | +MozzerellaBurger()            |
    | +VeggiesBurger()               |
    +--------------------------------+

    +-------------------------------+
    | FacadeDesignPatternOrnekClass |
    +-------------------------------+
    | +FacadeDesignPatternOrnekRunMethod() |
    +-------------------------------+


    */


}