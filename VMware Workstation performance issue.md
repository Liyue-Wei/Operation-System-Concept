# <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/5a/Vmware_workstation_16_icon.svg/1200px-Vmware_workstation_16_icon.svg.png" width="35px" alt="VM"> VMware Workstation performance issue 
###### tags: `VMware` `Virtualization` `Solution`

Solutions for VMware virtualization performance issues on Hybrid Architecture (big.LITTLE) CPUs.


## Socpe of Application 
### 1. Hardware - CPUs with Hybrid Architecture Design
*   Intel Core i series CPUs (12th generation and later)  <sub>**(e.g., Intel Core i5-12500H)**</sub>
*   Intel Core Ultra CPUs <sub>**(e.g. Intel Core Ultra 7 Processor 265K)**</sub>
*   Intel Core series CPUs <sub>**(e.g. Intel Core 3 Processor 100U)**</sub>
*   AMD Ryzen AI 300 Series CPUs <sub>**(e.g. AMD Ryzen AI 9 HX 370)**</sub> *(Limited testing)*


### 2. Software

#### System:

*   Windows 11 (23H2 and later)

#### VMware:

*   VMware Workstation Pro 17 (and later)
*   VMware Workstation Player 17 (and later)

## Reason
Since 2021, Intel has introduced the brand new 12th generation Core i Processors <sub>(Code Name: Alder Lake) </sub>with Hybrid Architecture Design. The rules for how operating systems interact with CPUs have considerable changes. Microsoft released Windows 11 soon after to improve the performance experience when 12th generation Intel processors were running on Windows 10.

Intel's Thread Director also presented challenges for VMware Workstation Pro and Player.  Virtual machines running on these platforms might experience performance limitations due to the complexities of efficiently managing threads with the new technology.

Disabling Hyper-V allows VMware Workstation Pro and Player to directly manage the hardware and implement its own virtualization, rather than operating within the Hyper-V environment.

## Solutions
To resolve this issue, follow the steps one by one.

1. Disable "**Core isolation**" in Windows Security
2. Disable "**Windows Hypervisor Platform**" and "**Virtual Machine Platform**" options in Windows Features
3. Restart your computer
4. Run VMware Worksation Pro or Player as an Administrator.

If the issue persists, reinstall VMware Workstation and repeat the steps above.

Enjoy your improved virtualization experience!
___
### Authored by [**Liyue-Wei**](https://github.com/Liyue-Wei) on GitHub