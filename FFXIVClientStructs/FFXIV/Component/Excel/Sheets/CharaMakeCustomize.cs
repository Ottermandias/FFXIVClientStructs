// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x14)]
public unsafe partial struct CharaMakeCustomize {
    [FieldOffset(0x00)] public uint Icon;
    /// <remarks>Lobby</remarks>
    [FieldOffset(0x04)] public uint Hint;
    /// <remarks>Item</remarks>
    [FieldOffset(0x08)] public uint HintItem;
    [FieldOffset(0x0C)] public ushort Data;
    [FieldOffset(0x0E)] public byte FeatureID;
    [FieldOffset(0x0F)] public byte Unknown0;
    [FieldOffset(0x10)] public bool IsPurchasable;
}