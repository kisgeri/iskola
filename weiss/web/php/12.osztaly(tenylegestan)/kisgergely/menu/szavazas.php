<?php
if( !isset($_SESSION['szavazva']))
{
    print" <form action='szavazas_ir.php' method='post' target='kisablak'>
        
        <input type='radio' name='betuk' value='1'> banán <br>
        <input type='radio' name='betuk' value='2'> borsó <br>
        <input type='radio' name='betuk' value='3'> sárga répa <br>
        <input type='radio' name='betuk' value='4'> alma <br>

        <input type='submit' value='beküldés'>
    </form>

    <iframe src='' frameborder='0' name='kisablak'>

    </iframe>";
}
else{
    $fajlnev = "szavazas.txt";

    $fp = fopen($fajlnev,"r");
    $sz = fread($fp, filesize($fajlnev));
    fclose($fp);

    $allas = explode(";",$sz);
    $ossz = array_sum($allas);

    $a[0]= round($allas[0]/$ossz*100);
    $a[1]= round($allas[1]/$ossz*100);
    $a[2]= round($allas[2]/$ossz*100);
    $a[3]= round($allas[3]/$ossz*100);


    print"
    <style>
        table tr td span
        {
            display: block;
            height: 16px;
            background-color: #484;
        }
    </style>
    <table>
        <tr> <td>tavasz:<td> $a[0]% <td> <span style='width: ".$a[0]."px;'></span>
        <tr> <td>nyár:<td> $a[1]% <td> <span style='width: ".$a[1]."px;'></span>
        <tr> <td>ősz:<td> $a[2]% <td> <span style='width: ".$a[2]."px;'></span>
        <tr> <td>tél:<td> $a[3]%<td> <span style='width: ".$a[3]."px;'></span>
    </table>
    ";
}
   $_SESSION['szavazva']=1;

   
   print"
    <script>parent.location.href = parent.location.href</script>
   ";
?>