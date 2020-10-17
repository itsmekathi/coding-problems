#include <stdio.h>
#include <stdlib.h>

struct node
{
    int data;
    struct node *next;
};
struct node *head;

void insertFront();
void insertLast();
void randomInsert();
void beginDelete();
void lastDelete();
void randomDelete();
void display();
void search();

void main()
{
    int choice = 0;
    while (choice != 9)
    {
        printf("\n\n************Main Menu**************\n");
        printf("\nChoose one option from the following list..\n");
        printf("\n1.Insert in begining\n2.Insert at last\n3.Insert at any random location\n");
        printf("4.Delete from beginning\n5.Delte from last\n.6.Delete node after specified  location\n");
        printf("7.Search for an element\n8.Show\n9.Exit\n");
        printf("Enter your choice?\n");
        scanf("\n%d", &choice);
        switch (choice)
        {
        case 1:
            insertFront();
            break;
        case 2:
            insertLast();
            break;
        case 3:
            randomInsert();
            break;
        case 4:
            beginDelete();
            break;
        case 5:
            lastDelete();
            break;
        case 6:
            randomDelete();
            break;
        case 7:
            search();
            break;
        case 8:
            display();
            break;
        case 9:
            exit(0);
            break;
        default:
            printf("Please enter a valid choice.");
            break;
        }
    }
}

void insertFront()
{
    struct node *ptr;
    int item;
    ptr = (struct node *)malloc(sizeof(struct node));
    if (ptr == NULL)
    {
        printf("\nOVERFLOW");
    }
    else
    {
        printf("\nEnter value");
        scanf("%d", &item);
        ptr->data = item;
        ptr->next = head;
        head = ptr;
        printf("\nNode inserted");
    }
}

void insertLast()
{
    struct node *ptr,
        *temp;

    int item;
    ptr = (struct node *)malloc(sizeof(struct node));
    if (ptr == NULL)
    {
        printf("\nOVERFLOW");
    }
    else
    {
        printf("\nEnter value?\n");
        scanf("%d", &item);
        ptr->data = item;

        if (head == NULL)
        {
            ptr->next = NULL;
            head = ptr;
            printf("\nNode inserted");
        }
        else
        {
            temp = head;
            while (temp->next != NULL)
            {
                temp = temp->next;
            }
            temp->next = ptr;
            ptr->next = NULL;
            printf("\nNode inserted");
        }
    }
}

void randomInsert()
{
    int i, loc, item;
    struct node *ptr, *temp;
    ptr = (struct node *)malloc(sizeof(struct node));
    if (ptr == NULL)
    {
        printf("\nOVERFLOW");
    }
    else
    {
        printf("\nEnter element value");
        scanf("%d", &item);
        ptr->data = item;
        printf("\nEnter the location after which you want to insert");
        scanf("\n%d", &loc);
        temp = head;
        for (i = 0; i < loc; i++)
        {
            temp = temp->next;
            if (temp == NULL)
            {
                printf("\nCant insert\n");
                return;
            }
        }
        ptr->next = temp->next;
        temp->next = ptr;
        printf("\nNode inserted");
    }
}

void beginDelete()
{
    struct node *ptr;
    if (head == NULL)
    {
        printf("\nList is empty");
    }
    else
    {
        ptr = head;
        head = ptr->next;
        free(ptr);
        printf("\nNode deleted from the beginning...");
    }
}

void lastDelete()
{
    struct node *prev, *temp;
    if (head == NULL)
    {
        printf("\nList is empty");
    }
    else if (head->next == NULL)
    {
        head = NULL;
        free(head);
        printf("\nOnly node of the list deleted");
    }

    else
    {
        temp = head;
        while (temp->next != NULL)
        {
            prev = temp;
            temp = temp->next;
        }
        prev->next = NULL;
        free(temp);
        printf("\nNode deleted from the last...");
    }
}

void randomDelete()
{
    struct node *ptr, *prev;
    int loc, i;
    printf("\n Enter the location of the node after which you want to perform deletion \n");
    scanf("%d", &loc);

    ptr = head;
    for (i = 0; i < loc; i++)
    {
        prev = ptr;
        ptr = ptr->next;
        if (ptr == NULL)
        {
            printf("\nCan't delete");
            return;
        }
    }
    prev->next = ptr->next;
    free(ptr);
    printf("\nDeleted node %d", loc + 1);
}
void display()
{
    struct node *ptr;
    ptr = head;
    if (ptr == NULL)
    {
        printf("Nothing to print");
    }
    else
    {
        printf("\nData: ");
        while (ptr != NULL)
        {
            printf("->%d", ptr->data);
            ptr = ptr->next;
        }
        printf("\n");
    }
}
void search()
{
    struct node *ptr;
    int item, i = 0, flag;
    ptr = head;
    if (ptr == NULL)
    {
        printf("\nEmpty List");
    }
    else
    {
        printf("Enter item which you want to search?\n");
        scanf("%d", &item);
        while (ptr != NULL)
        {
            if (ptr->data == item)
            {
                printf("Item found at location %d", i + 1);
                flag = 0;
            }
            else
            {
                flag = 1;
            }
            i++;
            ptr = ptr->next;
        }
        if (flag == 1)
        {
            printf("Item not found\n");
        }
    }
}