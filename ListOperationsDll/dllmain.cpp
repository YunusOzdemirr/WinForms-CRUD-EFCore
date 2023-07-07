// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <iostream>
#include <list>


#define EXPORTED_METHOD extern "C" __declspec(dllexport)

EXPORTED_METHOD
extern "C" {
    EXPORTED_METHOD
    struct Node {
        int data;
        struct Node* next;
    };

    struct ListOperations {
        std::list<int> myList;
    };

    EXPORTED_METHOD
    ListOperations* CreateListOperations() {
        return new ListOperations();
    }
    EXPORTED_METHOD
    void DeleteListOperations(ListOperations* listOps) {
        delete listOps;
    }
    EXPORTED_METHOD
    void AddToList(ListOperations* listOps, int data) {
        listOps->myList.push_back(data);
    }
    EXPORTED_METHOD
    Node* GetList(ListOperations* listOps) {
        if (listOps->myList.empty()) {
            return nullptr;
        }

        Node* head = nullptr;
        Node* current = nullptr;

        for (int data : listOps->myList) {
            Node* newNode = new Node;
            newNode->data = data;
            newNode->next = nullptr;

            if (head == nullptr) {
                head = newNode;
                current = newNode;
            }
            else {
                current->next = newNode;
                current = newNode;
            }
        }

        return head;
    }
    EXPORTED_METHOD
    void PrintList(Node* head) {
        Node* current = head;
        while (current != nullptr) {
            std::cout << current->data << " ";
            current = current->next;
        }
        std::cout << std::endl;
    }
}




BOOL APIENTRY DllMain(HMODULE hModule,
	DWORD  ul_reason_for_call,
	LPVOID lpReserved
)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

