declare gobalName="Publishers"
declare controller=$gobalName

## Folders 
mkdir "Controllers/${controller}"
cd "Controllers/${controller}"

## Files
touch "${controller}CreateController.cs"
touch "${controller}UpdateController.cs"
touch "${controller}DeleteController.cs"
touch "${controller}Controller.cs"

###----- go back to ../controllerName../controller
cd ../../
declare service=$gobalName
##---- Folders ----##
mkdir -p "Services/${service}Repository"
cd "Services/${service}Repository"

##---- Folders ----##
## First create main repository class with its interface
touch "${service}Repository.cs"
touch "I${service}Repository.cs"

## Now HTTP methods
# corrent route: Services/ServiceRepository/
mkdir "${service}Methods"
cd "${service}Methods"

touch "${service}Get.cs"
touch "${service}Create.cs"
touch "${service}Update.cs"
touch "${service}Delete.cs"