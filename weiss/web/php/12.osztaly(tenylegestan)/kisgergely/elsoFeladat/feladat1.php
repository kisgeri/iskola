
<style>

	h1
	{
		text-align		: center	;
		color			: #001a1a		;
	}

	table
	{
		margin			: 24px auto	;
		border			: solid 1px #88C;
	}

	td
	{
		text-align		: center	;
		background-color	: #BBD		;
		color			: #224
	}

	tr:first-child td , td:nth-child(1)
	{
		background-color	: #88C		;
		font-weight		: bold		;
	}

    #szorzotabla
    {
	border           : solid  1px  green  ;
	box-shadow       : 4px 4px 4px #6A6   ;
	border-radius    : 8px                ;
	background-color : #3A3               ;
    }

    #szorzotabla tr td
    {
	width            : 32px    ;
	text-align       : right   ;
	padding-right    : 4px     ;
	line-height      : 20px    ;
	font-family      : Arial   ;
	font-size        : 12px    ;
	border-radius    : 4px     ;
	background-color : #CFC    ;
    }


    #szorzotabla tr:first-child td    , #szorzotabla tr td:first-child
    {
	background-color : #4C4    ;
	font-weight      : bold    ;
    }

	

    </style>

    <h1>Összegző</h1>

        <table width=240>

        <tr>

            <td>   N  </td>
            <td>   Σ N    </td>

        </tr>

    <?php
        $osszeg = 0;

        for( $i=1; $i<=100; $i++)
        {
            $osszeg = $osszeg + $i;
        print "
            <tr>

                <td>                       $i       </td>
                <td>                       $osszeg  </td>

            </tr>
        " ;

        }

    ?>

        

        </table>
        <hr>
        <br>

        <h1>Szorzótábla</h1>

<table id='szorzotabla'>

    <?php
    if( isset($_GET['a']) )
    {
        $a = $_GET['a'];
    }
    else
    {
        $a= 10;
    }

    for( $i=1; $i<=$a; $i++)
    {
        print "<tr>";
        for( $j=1; $j<=$a; $j++)
        {
            print"<td>".$j*$i."</td>";
        }
        print"</tr>";
    }

    ?>



</table>


    