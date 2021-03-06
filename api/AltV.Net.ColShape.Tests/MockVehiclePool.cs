using System;
using System.Collections.Generic;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Net.ColShape.Tests
{
    public class MockVehiclePool : IEntityPool<IVehicle>
    {
        public void Create(IntPtr entityPointer, ushort id)
        {
            throw new NotImplementedException();
        }

        public void Create(IntPtr entityPointer, ushort id, out IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public void Create(IntPtr entityPointer, out IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IntPtr entityPointer)
        {
            throw new NotImplementedException();
        }

        public bool Get(IntPtr entityPointer, out IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool GetOrCreate(IntPtr entityPointer, ushort entityId, out IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool GetOrCreate(IntPtr entityPointer, out IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<IVehicle> GetAllEntities()
        {
            var mockVehicle = new MockVehicle() {Position = new Position(1, 1, 1)};
            var vehicles = new List<IVehicle> {mockVehicle};
            return vehicles;
        }
        
        public KeyValuePair<IntPtr, IVehicle>[] GetEntitiesArray()
        {
            var mockVehicle = new MockVehicle() {Position = new Position(1, 1, 1)};
            var vehicles = new List<IVehicle> {mockVehicle};
            var arr = new KeyValuePair<IntPtr, IVehicle>[vehicles.Count];
            var i = 0;
            foreach (var entity in vehicles)
            {
                arr[i++] = new KeyValuePair<IntPtr, IVehicle>(IntPtr.Zero, entity);
            }

            return arr;
        }

        public void OnAdd(IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public void OnRemove(IVehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}