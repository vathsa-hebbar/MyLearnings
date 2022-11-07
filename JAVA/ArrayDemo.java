import java.util.Scanner;

class ArrayDemo {
    public static void main(String args[]) {
        Scanner scan =new Scanner(System.in);
        int size;
        int ar[] = new int[100]; // array initialization and declaring
        // int ar[] = new int[]{1,2,3,4,5}; //array initialization and declaring statically
        System.out.println("Enter the size of the array");
        size = scan.nextInt();
        System.out.println("Enter the array elements"); 
        for (int i = 0; i <= size; i++){ // array insertion dynamically
            ar[i] = scan.nextInt();
        }

        for (int i = 0; i <= size; i++){
            System.out.print(ar[i]+" ");
        } 
    }
}
