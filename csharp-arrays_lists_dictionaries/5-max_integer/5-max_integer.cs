using System.Collections;

class List{
    public static int MaxInteger(List<int> myList){
        if(myList.Count <= 0){
            Console.WriteLine("List is empty");
            return -1;
        }else{
            int maxiValue = myList[0];

            foreach(int temp in myList){

                if(temp > maxiValue){
                    maxiValue = temp;
                }
            }
            return maxiValue;
        }
    }
}