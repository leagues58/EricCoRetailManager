using Caliburn.Micro;
using ERMDesktopUI.Library.API;
using ERMDesktopUI.Library.Models;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ERMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        IProductEndpoint _productEndpoint;

        public SalesViewModel(IProductEndpoint productEndpoint)
        {
            _productEndpoint = productEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var productList = await _productEndpoint.GetAll();
            Products = new BindingList<ProductModel>(productList);
        }

        private BindingList<ProductModel> _products;

        public BindingList<ProductModel> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<CartItemModel> _cart;

        public BindingList<CartItemModel> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
                NotifyOfPropertyChange(() => CanAddToCart);
            }
        }

        private ProductModel _selectedProduct;

        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                NotifyOfPropertyChange(() => SelectedProduct);
                NotifyOfPropertyChange(() => CanAddToCart);
            }
        }

        public string SubTotal
        {
            get
            {
                // replace with calculation
                return "";
            }
        }

        public string Tax
        {
            get
            {
                // replace with calculation
                return "";
            }
        }

        public string Total
        {
            get
            {
                // replace with calculation
                return "";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;
                // make sure something is selected
                // make sure there is an item quantity
                if (ItemQuantity > 0 && SelectedProduct?.QuantityInStock >= ItemQuantity)
                {
                    output = true;
                }

                return false;
            }
        }

        public void AddToCard()
        {
            CartItemModel item = new CartItemModel()
            {
                Product = SelectedProduct,
                QuantityInCart = ItemQuantity
            };

            Cart.Add(item);
        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;
                // make sure something is selected
                // make sure there is an item quantity

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }


        public bool CanCheckOut
        {
            get
            {
                bool output = false;
                // make sure something is in the cart

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}
