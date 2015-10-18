﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Linq;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DataEntities", "CartCartItem", "Cart", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(RS_Kata.Cart), "CartItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(RS_Kata.CartItem), true)]
[assembly: EdmRelationshipAttribute("DataEntities", "CartItemItem", "CartItem", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(RS_Kata.CartItem), "Item", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(RS_Kata.Item))]
[assembly: EdmRelationshipAttribute("DataEntities", "ItemDiscount", "Item", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(RS_Kata.Item), "Discount", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(RS_Kata.Discount), true)]

#endregion

namespace RS_Kata
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DataEntitiesContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DataEntitiesContainer object using the connection string found in the 'DataEntitiesContainer' section of the application configuration file.
        /// </summary>
        public DataEntitiesContainer() : base("name=DataEntitiesContainer", "DataEntitiesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DataEntitiesContainer object.
        /// </summary>
        public DataEntitiesContainer(string connectionString) : base(connectionString, "DataEntitiesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DataEntitiesContainer object.
        /// </summary>
        public DataEntitiesContainer(EntityConnection connection) : base(connection, "DataEntitiesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cart> Carts
        {
            get
            {
                if ((_Carts == null))
                {
                    _Carts = base.CreateObjectSet<Cart>("Carts");
                }
                return _Carts;
            }
        }
        private ObjectSet<Cart> _Carts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Item> Items
        {
            get
            {
                if ((_Items == null))
                {
                    _Items = base.CreateObjectSet<Item>("Items");
                }
                return _Items;
            }
        }
        private ObjectSet<Item> _Items;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Discount> Discounts
        {
            get
            {
                if ((_Discounts == null))
                {
                    _Discounts = base.CreateObjectSet<Discount>("Discounts");
                }
                return _Discounts;
            }
        }
        private ObjectSet<Discount> _Discounts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CartItem> CartItems
        {
            get
            {
                if ((_CartItems == null))
                {
                    _CartItems = base.CreateObjectSet<CartItem>("CartItems");
                }
                return _CartItems;
            }
        }
        private ObjectSet<CartItem> _CartItems;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Carts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCarts(Cart cart)
        {
            base.AddObject("Carts", cart);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Items EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItems(Item item)
        {
            base.AddObject("Items", item);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Discounts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDiscounts(Discount discount)
        {
            base.AddObject("Discounts", discount);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CartItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCartItems(CartItem cartItem)
        {
            base.AddObject("CartItems", cartItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataEntities", Name="Cart")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cart : EntityObject
    {
		public void UpdateCartTotal()
		{
			TotalCost = 0.00;

			foreach(CartItem cartItem in CartItems)
			{
				TotalCost += cartItem.GetExtendedPrice();
			}
		}

        #region Factory Method
    
        /// <summary>
        /// Create a new Cart object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="totalCost">Initial value of the TotalCost property.</param>
        public static Cart CreateCart(global::System.Int32 id, global::System.Double totalCost)
        {
            Cart cart = new Cart();
            cart.Id = id;
            cart.TotalCost = totalCost;
            return cart;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double TotalCost
        {
            get
            {
                return _TotalCost;
            }
            set
            {
                OnTotalCostChanging(value);
                ReportPropertyChanging("TotalCost");
                _TotalCost = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalCost");
                OnTotalCostChanged();
            }
        }
        private global::System.Double _TotalCost;
        partial void OnTotalCostChanging(global::System.Double value);
        partial void OnTotalCostChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataEntities", "CartCartItem", "CartItem")]
        public EntityCollection<CartItem> CartItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CartItem>("DataEntities.CartCartItem", "CartItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CartItem>("DataEntities.CartCartItem", "CartItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataEntities", Name="CartItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CartItem : EntityObject
    {
		//calculates the price of all the items including discounts. Discounts are only given for exact quantity groupings.
		public double GetExtendedPrice()
		{
			//if the item wasn't found, we will return a zero
			if (Item == null)
			{
				return 0;
			}

			if (Item.Discounts.Count > 0)
			{
				Discount discount = Item.Discounts.FirstOrDefault();
				if (ItemQty >= discount.QtyRequired)
				{
					int discountQty = ItemQty / discount.QtyRequired;
					int nonDiscountQty = ItemQty % discount.QtyRequired;
					return (discountQty * discount.DiscountedPrice) + (nonDiscountQty * Item.Price);
				}
			}

			return ItemQty*Item.Price;

		}

        #region Factory Method
    
        /// <summary>
        /// Create a new CartItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="cartId">Initial value of the CartId property.</param>
        /// <param name="itemQty">Initial value of the ItemQty property.</param>
        public static CartItem CreateCartItem(global::System.Int32 id, global::System.Int32 cartId, global::System.Int32 itemQty)
        {
            CartItem cartItem = new CartItem();
            cartItem.Id = id;
            cartItem.CartId = cartId;
            cartItem.ItemQty = itemQty;
            return cartItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CartId
        {
            get
            {
                return _CartId;
            }
            set
            {
                OnCartIdChanging(value);
                ReportPropertyChanging("CartId");
                _CartId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CartId");
                OnCartIdChanged();
            }
        }
        private global::System.Int32 _CartId;
        partial void OnCartIdChanging(global::System.Int32 value);
        partial void OnCartIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ItemQty
        {
            get
            {
                return _ItemQty;
            }
            set
            {
                OnItemQtyChanging(value);
                ReportPropertyChanging("ItemQty");
                _ItemQty = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ItemQty");
                OnItemQtyChanged();
            }
        }
        private global::System.Int32 _ItemQty;
        partial void OnItemQtyChanging(global::System.Int32 value);
        partial void OnItemQtyChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataEntities", "CartCartItem", "Cart")]
        public Cart Cart
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cart>("DataEntities.CartCartItem", "Cart").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cart>("DataEntities.CartCartItem", "Cart").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Cart> CartReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cart>("DataEntities.CartCartItem", "Cart");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Cart>("DataEntities.CartCartItem", "Cart", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataEntities", "CartItemItem", "Item")]
        public Item Item
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("DataEntities.CartItemItem", "Item").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("DataEntities.CartItemItem", "Item").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Item> ItemReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("DataEntities.CartItemItem", "Item");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Item>("DataEntities.CartItemItem", "Item", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataEntities", Name="Discount")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Discount : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Discount object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="qtyRequired">Initial value of the QtyRequired property.</param>
        /// <param name="discountedPrice">Initial value of the DiscountedPrice property.</param>
        /// <param name="itemId">Initial value of the ItemId property.</param>
        public static Discount CreateDiscount(global::System.Int32 id, global::System.Int32 qtyRequired, global::System.Double discountedPrice, global::System.Int32 itemId)
        {
            Discount discount = new Discount();
            discount.Id = id;
            discount.QtyRequired = qtyRequired;
            discount.DiscountedPrice = discountedPrice;
            discount.ItemId = itemId;
            return discount;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QtyRequired
        {
            get
            {
                return _QtyRequired;
            }
            set
            {
                OnQtyRequiredChanging(value);
                ReportPropertyChanging("QtyRequired");
                _QtyRequired = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QtyRequired");
                OnQtyRequiredChanged();
            }
        }
        private global::System.Int32 _QtyRequired;
        partial void OnQtyRequiredChanging(global::System.Int32 value);
        partial void OnQtyRequiredChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double DiscountedPrice
        {
            get
            {
                return _DiscountedPrice;
            }
            set
            {
                OnDiscountedPriceChanging(value);
                ReportPropertyChanging("DiscountedPrice");
                _DiscountedPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DiscountedPrice");
                OnDiscountedPriceChanged();
            }
        }
        private global::System.Double _DiscountedPrice;
        partial void OnDiscountedPriceChanging(global::System.Double value);
        partial void OnDiscountedPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ItemId
        {
            get
            {
                return _ItemId;
            }
            set
            {
                OnItemIdChanging(value);
                ReportPropertyChanging("ItemId");
                _ItemId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ItemId");
                OnItemIdChanged();
            }
        }
        private global::System.Int32 _ItemId;
        partial void OnItemIdChanging(global::System.Int32 value);
        partial void OnItemIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataEntities", "ItemDiscount", "Item")]
        public Item Item
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("DataEntities.ItemDiscount", "Item").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("DataEntities.ItemDiscount", "Item").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Item> ItemReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Item>("DataEntities.ItemDiscount", "Item");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Item>("DataEntities.ItemDiscount", "Item", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataEntities", Name="Item")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Item : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Item object.
        /// </summary>
        /// <param name="sKU">Initial value of the SKU property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        /// <param name="id">Initial value of the Id property.</param>
        public static Item CreateItem(global::System.String sKU, global::System.Double price, global::System.Int32 id)
        {
            Item item = new Item();
            item.SKU = sKU;
            item.Price = price;
            item.Id = id;
            return item;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SKU
        {
            get
            {
                return _SKU;
            }
            set
            {
                OnSKUChanging(value);
                ReportPropertyChanging("SKU");
                _SKU = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SKU");
                OnSKUChanged();
            }
        }
        private global::System.String _SKU;
        partial void OnSKUChanging(global::System.String value);
        partial void OnSKUChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Double _Price;
        partial void OnPriceChanging(global::System.Double value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataEntities", "CartItemItem", "CartItem")]
        public CartItem CartItem
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CartItem>("DataEntities.CartItemItem", "CartItem").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CartItem>("DataEntities.CartItemItem", "CartItem").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CartItem> CartItemReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CartItem>("DataEntities.CartItemItem", "CartItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CartItem>("DataEntities.CartItemItem", "CartItem", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataEntities", "ItemDiscount", "Discount")]
        public EntityCollection<Discount> Discounts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Discount>("DataEntities.ItemDiscount", "Discount");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Discount>("DataEntities.ItemDiscount", "Discount", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
