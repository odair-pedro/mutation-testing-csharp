dotnet stryker |
while read -r line
do
    echo $line
    if echo $line | grep '.*mutation-report\.html'
    then
        echo "Opening report: $line"
        xdg-open $line        
    fi
done