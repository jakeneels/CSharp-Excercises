using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            int birds = 4 - 1;
            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            birds = 6 - 3;
            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            var raccoons = 3 - 2;
            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            short beesLess = 5 - 3;
            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            var pigeons = 1 + 1;
            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int owls = 3;
            owls += 2;
            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            byte beavers = 2;
            beavers -= 1;
            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            var toucans = 2;
            toucans += 1;
            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            var squirrels = 4;
            squirrels /= 2;
            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            double money = .25 + .10 + .05;
            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int muffins = 18;
            muffins += 20;
            muffins += 17;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            var toyCost = .24;
            toyCost += .14;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            var marshmaaaaaaallows = 8 + 10; //i've been spelling it wrong for my entire life
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            var inchesOfSnow = 29 - 17;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            double hiltsMoney = 10;
            hiltsMoney -= 3;
            hiltsMoney -= 2;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            var marbles = 16;
            marbles -= 7;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            var seashells = 19;
            seashells += 25 - 19;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            var balloons = 17;
            var redBalloons = 8;
            var greenBalloons = balloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            byte books = 38;
            books += 10;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int legsOnAHealthyBee = 6;
            int numberOfBees = 8;
            int totalLegs = legsOnAHealthyBee * numberOfBees;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            var coneCost = 0.99;
            int conesBought = 2;
            double totalCost = coneCost + conesBought;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksOwned = 64;
            const int TOTAL_ROCKS_NEEDED= 125;
            int rocksStillNeeded = rocksOwned - TOTAL_ROCKS_NEEDED;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            var hiltsMarbles = 38;
            hiltsMarbles -= 15;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            double milesLeft = 78 - 32;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int minutesSpent = 90 + 45;
            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hotDogsBought = 6;
            double hotDogPrice = 0.5;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            float pencilCost = 0.07f;
            float totalMoney = 0.5f;
            Console.WriteLine(totalMoney / pencilCost);
            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = butterflies - orangeButterflies;
            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double centsGiven = 100;
            double itemCost = 0.54;
            double centsChange = centsGiven - itemCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInBackyard = 13;
            treesInBackyard += 12;
            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int dayInHours = 24;
            int daysTillJoySeesGrandma = dayInHours * 2;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            var numOfCousins = 4;
            var piecesNeeded = numOfCousins * 5;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            const double COST_OF_CANDYBAR = 1.00;
            double dansMoney = 3.00;
            double moneyLeft = dansMoney - COST_OF_CANDYBAR;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            var boatsInLake = 5;
            var peopleOnBoat = 3;
            var peopleOnLake = boatsInLake * peopleOnBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            var legosOwned = 380;
            var legosLost = 57;
            var legosRemaining = legosOwned - legosLost;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            muffins = 35;
            int muffinsWanted = 83;
            int muffinsNeeded = muffinsWanted - muffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int moreThanLucy = willysCrayons - lucysCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnPage = 10;
            int pagesOfStickers = 22;
            int stickers = stickersOnPage * pagesOfStickers;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            var cupcakes = 96;
            var children = 8;
            Console.WriteLine(cupcakes / children);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            var gingerbreads = 47;
            var cookiesInJar = 6;
            Console.WriteLine(gingerbreads % cookiesInJar);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            var croissants = 59;
            var neighbors = 8;
            var neighborGets = croissants % neighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            var cookies = 276.0;
            var trayHolds = 12.0;
            Console.WriteLine(cookies / trayHolds);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            var pretzels = 480;
            var serving = 12;
            Console.WriteLine(pretzels/serving);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            cupcakes = 53;
            cupcakes -= 2;
            int boxHolds = 3;
            Console.WriteLine(cupcakes/boxHolds);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            var carrotSticks = 74;
            var peopleServed = 12;
            Console.WriteLine(carrotSticks % peopleServed);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            var bears = 98;
            var shelfHolds = 7;
            Console.WriteLine(bears / shelfHolds);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            var pics = 480;
            var albumHolds = 20;
            Console.WriteLine(480 / 20);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            var cards = 94;
            boxHolds = 8;
            Console.WriteLine(cards / boxHolds);
            Console.WriteLine(cards % boxHolds);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            books = 210;
            var shelfs = 10;
            Console.WriteLine(210 / 10);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            croissants = 17;
            var guests = 7;
            Console.WriteLine(croissants/guests);

        }
    }
}
