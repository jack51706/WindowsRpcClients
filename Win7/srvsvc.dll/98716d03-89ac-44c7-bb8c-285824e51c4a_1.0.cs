//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\srvsvc.dll
// Interface ID: 98716d03-89ac-44c7-bb8c-285824e51c4a
// Interface Version: 1.0



namespace rpc_98716d03_89ac_44c7_bb8c_285824e51c4a_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(char[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<char>(p0, p1, p2);
        }
        public void Write_3(char[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<char>(p0, p1, p2);
        }
        public void Write_4(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
        public void Write_5(char[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<char>(p0, p1, p2);
        }
        public void Write_6(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
        public void Write_7(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
        public void Write_8(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
        public void Write_9(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public char[] Read_2()
        {
            return ReadConformantVaryingArray<char>();
        }
        public char[] Read_3()
        {
            return ReadConformantVaryingArray<char>();
        }
        public sbyte[] Read_4()
        {
            return ReadConformantVaryingArray<sbyte>();
        }
        public char[] Read_5()
        {
            return ReadConformantVaryingArray<char>();
        }
        public sbyte[] Read_6()
        {
            return ReadConformantVaryingArray<sbyte>();
        }
        public sbyte[] Read_7()
        {
            return ReadConformantVaryingArray<sbyte>();
        }
        public sbyte[] Read_8()
        {
            return ReadConformantVaryingArray<sbyte>();
        }
        public sbyte[] Read_9()
        {
            return ReadConformantVaryingArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.WriteEmbeddedPointer<char[], long, long>(Member8, new System.Action<char[], long, long>(m.Write_2), (Member2 / 2), (Member0 / 2));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member8 = u.ReadEmbeddedPointer<char[]>(new System.Func<char[]>(u.Read_2), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public short Member2;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<char[]> Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(short Member0, short Member2, char[] Member8)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member8 = Member8;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<char[], long, long>(Member8, new System.Action<char[], long, long>(m.Write_3), Member4, Member4);
            m.WriteInt32(Member10);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member18, new System.Action<sbyte[], long, long>(m.Write_4), Member10, Member10);
            m.WriteInt32(Member20);
            m.WriteEmbeddedPointer<char[], long, long>(Member28, new System.Action<char[], long, long>(m.Write_5), Member20, Member20);
            m.WriteInt32(Member30);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member38, new System.Action<sbyte[], long, long>(m.Write_6), Member30, Member30);
            m.WriteInt32(Member40);
            m.WriteInt32(Member44);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member48, new System.Action<sbyte[], long, long>(m.Write_7), Member44, Member44);
            m.WriteInt32(Member50);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member58, new System.Action<sbyte[], long, long>(m.Write_8), Member50, Member50);
            m.WriteInt32(Member60);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member68, new System.Action<sbyte[], long, long>(m.Write_9), Member60, Member60);
            m.WriteInt32(Member70);
            m.WriteInt32(Member74);
            m.WriteInt32(Member78);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<char[]>(new System.Func<char[]>(u.Read_3), false);
            Member10 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_4), false);
            Member20 = u.ReadInt32();
            Member28 = u.ReadEmbeddedPointer<char[]>(new System.Func<char[]>(u.Read_5), false);
            Member30 = u.ReadInt32();
            Member38 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_6), false);
            Member40 = u.ReadInt32();
            Member44 = u.ReadInt32();
            Member48 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_7), false);
            Member50 = u.ReadInt32();
            Member58 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_8), false);
            Member60 = u.ReadInt32();
            Member68 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_9), false);
            Member70 = u.ReadInt32();
            Member74 = u.ReadInt32();
            Member78 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<char[]> Member8;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member18;
        public int Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<char[]> Member28;
        public int Member30;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member38;
        public int Member40;
        public int Member44;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member48;
        public int Member50;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member58;
        public int Member60;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member68;
        public int Member70;
        public int Member74;
        public int Member78;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(
                    int Member0, 
                    int Member4, 
                    char[] Member8, 
                    int Member10, 
                    sbyte[] Member18, 
                    int Member20, 
                    char[] Member28, 
                    int Member30, 
                    sbyte[] Member38, 
                    int Member40, 
                    int Member44, 
                    sbyte[] Member48, 
                    int Member50, 
                    sbyte[] Member58, 
                    int Member60, 
                    sbyte[] Member68, 
                    int Member70, 
                    int Member74, 
                    int Member78)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member40 = Member40;
            this.Member44 = Member44;
            this.Member48 = Member48;
            this.Member50 = Member50;
            this.Member58 = Member58;
            this.Member60 = Member60;
            this.Member68 = Member68;
            this.Member70 = Member70;
            this.Member74 = Member74;
            this.Member78 = Member78;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("98716d03-89ac-44c7-bb8c-285824e51c4a", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public void XsOpenPrinter(Struct_0 p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, ref System.Nullable<int> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteReferent(p2, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
        }
        // async
        public void XsClosePrinter(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, ref System.Nullable<int> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            p1 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
        }
        // async
        public void XsAddJob(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_0 p1, ref System.Nullable<Struct_0> p2, ref System.Nullable<int> p3, ref System.Nullable<int> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_0(p1);
            m.WriteReferent(p2, new System.Action<Struct_0>(m.Write_0));
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
        }
        // async
        public void XsScheduleJob(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref System.Nullable<int> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
        }
        // async
        public void XsProcessPnp(sbyte p0, Struct_0 p1, ref System.Nullable<int> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteSByte(p0);
            m.Write_0(p1);
            m.WriteReferent(p2, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(4, m);
            p2 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
        }
        // async
        public void XsProcDownLevelAPI(ref System.Nullable<Struct_1> p0, ref System.Nullable<int> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<Struct_1>(m.Write_1));
            m.WriteReferent(p1, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(5, m);
            p0 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p1 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
        }
    }
    #endregion
}

