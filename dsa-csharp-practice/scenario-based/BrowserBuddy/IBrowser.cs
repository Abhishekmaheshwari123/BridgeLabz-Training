using System;
interface IBrowser
{
    void RestoreTab();
    void MoveBackwardTab();
    void MoveForwardTab();
    void CloseTab();
    void AddTab();
}