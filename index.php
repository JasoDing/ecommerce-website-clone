<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/html">
<head>
    <meta charset="UTF-8">
    <title>Index Page</title>

    <!-- font awesome -->
    <script src="https://kit.fontawesome.com/69ba4cb72d.js"></script>

    <!-- css -->
    <link rel="stylesheet" href="main.css">
</head>
<body>

    <!-- Nav Bar-->
    <nav class="navbar">
        <div class="navbar-center">
            <span class="nav-icon">
                <i class="fas fa-bars"></i>
            </span>
            <img src="images/logo.svg" alt="store logo" />

            <div class="dropdown">
                <span class="nav-icon">
                    <button class="dropbtn">
                    <i class="fas fa-user"></i>
                    </button>
                </span>
                <ul class="dropdown-menu">
                    <li><a href="login.php">Login</a></li>
                    <li><a href="#">Log Out</a> </li>
                </ul>
            </div>

            <div class="cart-btn">
                <span class="nav-icon">
                    <i class="fas fa-cart-plus"></i>
                </span>
                <div class="cart-items">0</div>
            </div>
        </div>
    </nav>
    <!-- End of Nav Bar-->

    <!-- hero -->
    <header class="hero">
        <div class="banner">
            <h1 class="banner-title">Furniture collection</h1>
            <button class="banner-btn">Shop Now</button>
        </div>
    </header>
    <!-- End of Hero -->

    <!-- Products -->
    <section class="products">
        <div class="section-title">
            <h2>Our Products</h2>
        </div>
        <div class="products-center">
            <!--&lt;!&ndash; Single Product &ndash;&gt;-->
            <!--<article class="product">-->
            <!--<div class="img-container">-->
                <!--<img src="images/product-1.jpeg" alt="product" class="product-img">-->
                <!--<button class="bag-btn" data-id="1">-->
                    <!--<i class="fas fs-shopping-cart">-->
                        <!--Add to bag-->
                    <!--</i>-->
                <!--</button>-->
            <!--</div>-->
            <!--<h3>Queen bed</h3>-->
            <!--<h4>$16</h4>-->
            <!--</article>-->

            <!--&lt;!&ndash; End of Single Product&ndash;&gt;-->
        </div>
    </section>
    <!-- End of Products-->

    <!-- Cart -->
    <div class="cart-overlay">
        <div class="cart">
            <span class="close-cart">
                <i class="fas fa-window-close">
                </i>
            </span>
            <h2>Your Cart</h2>
            <div class="cart-content">

            </div>
            <div class="cart-footer">
                <h3>Your Total : $ <span class="cart-total">0</span></h3>
                <button class="close-cart banner-btn>">Clear Cart</button>
            </div>
        </div>
    </div>
    <!-- End of Cart -->

    <script src="js/app.js"></script>

</body>
</html>
