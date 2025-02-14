
<h1>elso php program</h1>

<?php
    print "hello világ!!! <hr>";

    if( isset($_GET['a']) )
    {
        $a = $_GET['a'];
    }
    else
    {
        $a= rand(1,100);
    }

    if( isset($_GET['b']) )
    {
        $b = $_GET['b'];
    }
    else
    {
        $b= rand(1,100);
    }
    

    print "$a * $b = " . $a * $b; //a kis pont . öszefűzi a szövegett mint máshol a +
    
    print "<br>";
    //az echo működik veszővel nem kell olyan pontosnak lenni

    echo "$a * $b = " , $a * $b;

    print "<br>";

    print "$a + $b = " . ($a + $b);

    print "<br>";

    echo "$a + $b = " , $a + $b;

    print "<br><br>";

    print "
            $a + $b ="  . ($a + $b). "<br>
            $a - $b ="  . ($a - $b). "<br> 
            $a * $b ="  . $a * $b. "<br> 
            $a / $b ="  . round($a / $b,2).  "<br>
            " ;//round(1571,-2) felkerekíti százasokra az egész számott

    if( !isset($_GET['a']) && !isset($_GET['b']) )
    {
        print "<hr><h3>használhatod a saját számaidat is</h3>
        <br>ha mósósitod az url-t így:<a href='http://localhost/kisgergely/elso/index.php?a=1345&b=2'>http://localhost/kisgergely/elso/index.php?a=1345&b=2</a> <hr>";
    }

    if(isset($_GET['b']) && $_GET['b']==0)
    {
        print"
        <script>

            alert('A \"b\" nem lehet 0');
            

        </script>
        ";
        /* \"b\" az jelenti hogy a b az kiiríndó 
        ezt akkor használjuk ha a " és a ' is használatba van véve
        */
    }

    

?>

