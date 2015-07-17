// Refactor the following if statements

Potato potato;
//... 
bool isOkPotato = potato != null &&
                  potato.hasBeenPeeled &&
                  potato.isOK;

if (isOkPotato)
{
    Cook(potato);
}

//

bool isValidX = MIN_X <= x && x <= MAX_X;
bool isValidY = MIX_Y <= y && y <= MAX_Y;
bool sellToVisit = true;

if (isValidX && isValidY && sellToVisit)
{
   VisitCell();
}
