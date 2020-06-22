var html3 = '<div class="collapse navbar-collapse" id="navbarSupportedContent" dropdown-menu-right>\
<ul class="navbar-nav mr-auto">\
    <li class="nav-item active">\
        <a class="nav-link" href="../index.html">Home <span class="sr-only">(current)</span></a>\
    </li>\
    <li class="nav-item dropdownB">\
        <a class="nav-link text-white dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">\
            Dashboards\
        </a>\
        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink" style="right: auto; left: auto;">\
                <a class="dropdown-item" href="../Misc/dashboard1.html">Map (Horizontal)</a>\
                <a class="dropdown-item" href="../Misc/dashboard2.html">Map (Vertical)</a>\
                <a class="dropdown-item" href="../Misc/dashboard3.html">Facilities & Inspections</a>\
                <a class="dropdown-item" href="../Misc/dashboard4.html">Consumption Habits</a>\
                <a class="dropdown-item" href="../Misc/dashboard5.html">Bad Actors</a>\
                <a class="dropdown-item" href="../Misc/dashboard6.html">Violations</a>\
                <a class="dropdown-item" href="../Misc/dashboard7.html">Age Groups vs City</a>\
                <a class="dropdown-item" href="../Misc/dashboard8.html">Behavior Analysis</a>\
                <a class="dropdown-item" href="../Misc/dashboard9.html">Level of Importance</a>\
        </div>\
    </li>\
    <li class="nav-item active">\
        <a class="nav-link" href="Misc/machinelearning.html">Machine Learning </a>\
    </li>\
    <li class="nav-item active">\
        <a class="nav-link" href="https://github.com/mcarter-00/Rats-in-the-Restaurants">Github Repository </a>\
    </li>\
</ul>\
</div>';

document.getElementById('navMenu').innerHTML = html3;




var footerhtml = '<span class="text">© 2020 Copyright:\
     <a href="../index.html" style="color:silver background:#9352fd"><img src ="../Misc/images/m_legs.svg" height="20px" width="20px" alt="rats">Ladies Night</a></span>';

document.getElementById('footer').innerHTML = footerhtml;

function ratRates(){
    let containerDiv=document.getElementById("ratRates"),
    url="https://public.tableau.com/views/Rats-in-the-Restaurants/BehaviorAnalysis?:language=en&:display_count=y&:origin=viz_share_link";

    let viz = new tableau.Viz(containerDiv, url);
    
}
$(document).ready(function(){
       
        ratRates()
        });


     
        var html2 = '<div class="collapse navbar-collapse" id="navbarSupportedContent" dropdown-menu-right>\
        <ul class="navbar-nav mr-auto">\
            <li class="nav-item active">\
                <a class="nav-link" href="index.html">Home <span class="sr-only">(current)</span></a>\
            </li>\
            <li class="nav-item dropdownB">\
                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">\
                    Dashboards\
                </a>\
                <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink" style="right: auto; left: auto;">\
                        <a class="dropdown-item" href="Misc/dashboard1.html">Map (Horizontal)</a>\
                        <a class="dropdown-item" href="Misc/dashboard2.html">Map (Vertical)</a>\
                        <a class="dropdown-item" href="Misc/dashboard3.html">Facilities & Inspections</a>\
                        <a class="dropdown-item" href="Misc/dashboard4.html">Consumption Habits</a>\
                        <a class="dropdown-item" href="Misc/dashboard5.html">Bad Actors</a>\
                </div>\
            </li>\
        </ul>\
        </div>';
        document.getElementById('navMain').innerHTML = html2;