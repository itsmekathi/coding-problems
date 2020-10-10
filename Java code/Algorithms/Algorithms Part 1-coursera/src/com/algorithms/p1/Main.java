package com.algorithms.p1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        System.out.println("Enter the length of the array.");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int length = Integer.parseInt(br.readLine());
        QuickFindUF qf = new QuickFindUF(length);
        System.out.println("Entering command mode.");
        System.out.println("-----------------------------");
        do {
            System.out.println("Enter \"c\" to check connectivity or \"u\" to union to elements.");
            String command = br.readLine();
            int p, q;
            switch (command) {
                // Connected or not command
                case "c":
                    System.out.println("Enter the value of p");
                    p = Integer.parseInt(br.readLine());
                    System.out.println("Enter the value of q");
                    q = Integer.parseInt(br.readLine());
                    System.out.println("Nodes are " + (qf.connected(p, q) ? "" : "not ") + "connected");
                    break;
                case "u":
                    // Union command
                    System.out.println("Enter the value of p");
                    p = Integer.parseInt(br.readLine());
                    System.out.println("Enter the value of q");
                    q = Integer.parseInt(br.readLine());
                    qf.union(p, q);
                    break;
                case "p":
                    // Print the array
                    qf.printArray();
                    break;
                default:
                    break;
            }
            System.out.println("Type \"q\" to exit, any other key to continue.");
        } while (br.readLine() != "q");
        System.out.println("Exiting ...");
        System.out.println("-----------------------------");
    }
}
