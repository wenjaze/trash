#include <iostream> 
#include <algorithm> 
using namespace std;

int main()
{
    int n,m;
    cin>>m;
    for(;m>0;m--){
        cin>>n;
        int t[n];
        for(int i=0;i<n;i++){
            cin>>t[i];
            
        }
        cout<<t[0];
        for(int i=1;i<n;i++){
            cout<<" "<<t[i];
        }
        cout<<"\n";
        bool val = next_permutation(t,t+n);
        cout<<t[0];
        for(int i=1;i<n;i++){
            cout<<" "<<t[i];
        }
        cout<<"\n";
        cout<<"\n";
    }
}
