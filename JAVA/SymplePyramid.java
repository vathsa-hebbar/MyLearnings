import java.util.*
import java.util.Scanner;

//it is a simple pyramid program in javausing recursion function.
class SymplePyramid{
    public static void main(String args[]){
        int x ;       
        Scanner scan = new Scanner(System.in);
        System.out.println("enter the  numbers");
        x = scan.nextInt();
        simple_pyramid(x);
    }

    public static void simple_pyramid(int x){
        for(int i=x; i>=0 ; i--){
            for(int k=0; k<=i-1; k++){
                System.out.print(" ");
            }
            for(int j=x; j>=i; j--){
                System.out.print("* ");
            }
            System.out.println();
        }
    }
}
