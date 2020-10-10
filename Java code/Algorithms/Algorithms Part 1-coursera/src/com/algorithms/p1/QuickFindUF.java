package com.algorithms.p1;

public class QuickFindUF {
    private int[] id;

    public QuickFindUF(int N) {
        id = new int[N];
        for (int i = 0; i < N; i++) {
            id[i] = i;
        }
    }

    public boolean connected(int p, int q) {
        return id[p] == id[q];
    }

    public void union(int p, int q) {
        int pid = id[p];
        int qid = id[q];
        for (int i = 0; i < id.length; i++) {
            if (id[i] == pid) id[i] = qid;
        }
    }
    public  void printArray(){
        for(int i =0 ;i< id.length; i++){
            System.out.print("id[" + i + "]: "  + id[i] + ", ");
        }
        System.out.print("\b");
        System.out.println();
    }
}
